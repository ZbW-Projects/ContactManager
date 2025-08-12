using ContactManager.Presentation.Demo;
using ContactManager.Presentation.Demo.Models;
using System.ComponentModel;
using System.Linq;

namespace ContactManager.Presentation.Demo.Services
{
    public interface IContacts
    {
        BindingList<Contact> GetAll();
        BindingList<Contact> Search(string term);
        Contact GetById(string id);
        Contact Add(Contact c);
        void Update(Contact c);
    }

    public class InMemoryContacts : IContacts
    {
        private readonly BindingList<Contact> _all = new BindingList<Contact>();

        public InMemoryContacts()
        {
            _all.Add(new Contact { Id = "E-0001", FirstName = "Lena", LastName = "Meyer", Email = "lena@acme.ch", Role = ContactRole.Employee, Active = true, Phone = "+4179...", City = "Zürich", Zip = "8000" });
            _all.Add(new Contact { Id = "T-0001", FirstName = "Joel", LastName = "Keller", Email = "joel@example.ch", Role = ContactRole.Trainee, Active = true });
            _all.Add(new Contact { Id = "C-0001", FirstName = "Mark", LastName = "Hofstetter", Email = "mark@foo.ch", Role = ContactRole.Customer, Active = false, Company = "Foo AG" });
        }

        public BindingList<Contact> GetAll() => _all;

        public BindingList<Contact> Search(string term)
        {
            term = (term ?? "").Trim().ToLowerInvariant();
            if (string.IsNullOrEmpty(term)) return new BindingList<Contact>(_all.ToList());
            var q = _all.Where(c =>
                 c.FirstName.ToLowerInvariant().Contains(term) ||
                 c.LastName.ToLowerInvariant().Contains(term) ||
                 c.Email.ToLowerInvariant().Contains(term) ||
                 c.Company.ToLowerInvariant().Contains(term));
            return new BindingList<Contact>(q.ToList());
        }

        public Contact GetById(string id) => _all.FirstOrDefault(c => c.Id == id);

        public Contact Add(Contact c)
        {
            var prefix = c.Role.ToString()[0]; // E/T/C
            var next = _all.Count(x => x.Role == c.Role) + 1;
            c.Id = $"{prefix}-{next:0000}";
            _all.Add(c);
            return c;
        }

        public void Update(Contact c)
        {
            var idx = _all.ToList().FindIndex(x => x.Id == c.Id);
            if (idx >= 0) _all[idx] = c;
        }
    }
}
