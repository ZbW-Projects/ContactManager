using MediatR;

namespace ContactManager.Domain.Common
{
    public abstract class Entity<TId> where TId : notnull
    {
        private readonly List<INotification> _domainEvents = new();

        public TId Id { get; protected init; }

        public bool IsTransient() => EqualityComparer<TId>.Default.Equals(Id, default!);

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(INotification eventItem)
        {
            if (eventItem is null) return;
            _domainEvents.Add(eventItem);
        }

        protected void RemoveDomainEvent(INotification eventItem)
        {
            if (eventItem is null) return;
            _domainEvents.Remove(eventItem);
        }

        public void ClearDomainEvents() => _domainEvents.Clear();

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj is not Entity<TId> other) return false;

            // Compare unproxied types to survive ORM proxies
            if (GetUnproxiedType(this) != GetUnproxiedType(other)) return false;

            if (IsTransient() || other.IsTransient()) return false;

            return EqualityComparer<TId>.Default.Equals(Id, other.Id);
        }

        public override int GetHashCode()
        {
            return IsTransient()
                ? base.GetHashCode()
                : HashCode.Combine(GetUnproxiedType(this), Id);
        }

        public static bool operator ==(Entity<TId>? left, Entity<TId>? right)
            => Equals(left, right);

        public static bool operator !=(Entity<TId>? left, Entity<TId>? right)
            => !Equals(left, right);

        private static Type GetUnproxiedType(object obj)
        {
            var type = obj.GetType();
            // If needed, strip proxies here (works for EF Core lazy proxies)
            // e.g., return type.BaseType is { IsAbstract: false } && type.Name.EndsWith("Proxy") ? type.BaseType! : type;
            return type;
        }
    }
}
