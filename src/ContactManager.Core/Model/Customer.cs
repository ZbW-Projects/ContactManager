using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{

    public class Customer : Person
    {
        #region Eigenschaften

        private string _companyName = "";
        private char _customerType;
        private string _companyContact = "";
        private Protocol _messages = new Protocol();

        #endregion

        public override string EmailPrivat { get; set; }
        public string CompanyName { get => _companyName; set => _companyName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Firmenname darf nicht leer sein.") : Name.Normalize(value); }
        public char CustomerType { get => _customerType; set => _customerType = !char.IsLetter(value) ? throw new ArgumentException("Der Kundentyp muss ein Buchstabe sein.", nameof(value)) : char.ToUpper(value); }
        public string CompanyContact { get => _companyContact; set => _companyContact = !Email.IsValid(value) ? throw new ArgumentException("Die Geschäftsemail ist nicht gültig.", nameof(value)) : value.Trim(); }
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
        [JsonInclude]
        public List<Message> Messages { get; private set; } = new();

        public void AddMessage(string content)
        {
            Messages.Add(new Message(content));
        }

    }

    public class Message
    {
        public string _owner;
        private Message() { }
        public Message(string content)
        {
            Content = content;
        }


        public string Owner { get => _owner; set => _owner = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Owner muss vorhanden sein.") : Name.Normalize(value); }
        [JsonInclude]
        public DateTime TimeStamp { get; private set; } = DateTime.UtcNow;
        [JsonInclude]
        public string Content { get; private set; }
    }
}
