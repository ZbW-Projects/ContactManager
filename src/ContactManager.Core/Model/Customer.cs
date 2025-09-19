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

        #endregion

        // Vorübergehende Lösung (um EmailPrivat zu überschreiben!)
        // ( Gibts bestimmt eine Elegantere Lösung )
        public override string EmailPrivat { get; set; } = string.Empty;
        public string CompanyName { get => _companyName; set => _companyName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Firmenname darf nicht leer sein.") : Name.Normalize(value); }
        public char CustomerType { get => _customerType; set => _customerType = !char.IsLetter(value) ? throw new ArgumentException("Der Kundentyp muss ein Buchstabe sein.") : char.ToUpper(value); }
        public string CompanyContact { get => _companyContact; set => _companyContact = !Email.IsValid(value) ? throw new ArgumentException("Die Geschäftsemail ist nicht gültig.") : value.Trim(); }
        [JsonInclude]
        public Protocol Messages { get; private set; } = new();
        public void AddMessage(string content, string owner) => Messages.Add(content, owner);
    }


    /*=================================================================================================
     * 
     * Kontakte / Gespräche zum Kunden werden protokolliert, Da ein Kunde mehrere Notizen haben kann, wurde eine Klasse "Protokol"
     * erstellt, die eine Liste als Datenstrucktur behält und entsprechende Methoden für ListenManipulation
     * bereitstellt, wie im Moment nur Einfügen "AddMessage".
     * ( Protokol ist wahrscheinlich überflüssig ?! )
     * 
     * ================================================================================================*/

    public class Protocol
    {
        [JsonInclude]
        public List<Message> Items { get; private set; } = new();

        public void Add(string content, string owner)
        {
            var msg = new Message(content, owner, DateTime.UtcNow);
            Items.Add(msg);
        }
    }

    public sealed class Message
    {
        private string _owner = string.Empty;
        [JsonConstructor]
        public Message(string content, string owner, DateTime timeStamp)
        {
            Content = content;
            Owner = owner;
            TimeStamp = timeStamp;
        }

        public string Owner { get => _owner; set => _owner = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Owner muss vorhanden sein.") : value.Trim(); }
        [JsonInclude]
        public DateTime TimeStamp { get; }
        [JsonInclude]
        public string Content { get; }
    }
}
