using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{

    public class Customer : Person
    {
        #region Eigenschaften

        private string _companyName;
        private char _customerType;
        private string _companyContact;
        private Protocol _messages = new Protocol();

        #endregion

        public string CompanyName { get => _companyName; set => _companyName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public char CustomerType { get => _customerType; set => _customerType = char.IsLetter(value) ? throw new ArgumentException("Der Wert muss ein Buchstabe sein.", nameof(value)) : char.ToUpper(value); }
        public string CompanyContact { get => _companyContact; set => _companyContact = !Email.IsValid(value) ? throw new ArgumentException("Die Email ist nicht gültig.", nameof(value)) : value.Trim(); }
        public Protocol Messages => _messages;
        public void AddMessage(string content) => _messages.AddMessage(content);
    }


    /*=================================================================================================
     * 
     * Kontakte / Gespräche zum Kunden werden protokolliert, Da ein Kunde mehrere Notizen haben kann, wurde eine Klasse "Protokol"
     * erstellt, die eine Liste als Datenstrucktur behält und entsprechende Methoden für ListenManipulation
     * bereitstellt, wie im Moment nur Einfügen "AddMessage".
     * 
     * ================================================================================================*/

    public class Protocol
    {
        private readonly List<Message> _messages = [];

        public void AddMessage(string content)
        {
            _messages.Add(new Message(content));
        }

    }

    public class Message(string content)
    {
        public DateTime TimeStamp { get; private set; } = DateTime.UtcNow;
        public string Content { get; private set; } = content;
    }
}
