using ContactManager.Domain.Common;

namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public abstract class SingleValueObject<T> : ValueObject
    {
        public T Value { get; }

        protected SingleValueObject(T value)
        {
            if (IsInvalid(value))
            {
                throw new ArgumentException("Value is Invalid", nameof(value));
            }

            Value = value;
        }

        protected virtual bool IsInvalid(T value)
        {
            // Basic defaults, override if needed
            if (value == null) return true;

            if (typeof(T) == typeof(string))
            {
                return string.IsNullOrWhiteSpace(value as string);
            }

            if (typeof(T) == typeof(DateTime))
            {
                return (DateTime)(object)value == default;
            }

            return false;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value?.ToString() ?? string.Empty;
    }
}
