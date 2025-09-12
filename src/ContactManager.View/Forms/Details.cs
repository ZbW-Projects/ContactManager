
using ContactManager.Core.Model;
using ContactManager.Core.Services;
using ContactManager.View.Forms.Components;
using System;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager.View.Forms
{
    public partial class Details : Form
    {


        //-----------------------------------
        // Zwei Szenarios UIs
        //-----------------------------------

        //-----------------------------------
        // Szenario 1 Erstellen von Kontakten 
        //-----------------------------------
        public Details()
        {
            InitializeComponent();
            //Controller.SpinData();
            CreateContactUISettings();
        }

        //------------------------------------
        // Szenario 2 Bearbeiten von Kontakten
        //------------------------------------
        public Details(Guid id, string type)
        {
            InitializeComponent();
            // Controller.SpinData();
            BearbeitenContactUISettings(type);
            // Kontakten abrufen 
            GetContactData(id, type);
        }

        // ---------------------------------------------------------------------
        // Aktionen
        // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Erstellen
        // ---------------------------------------------------------------------

        private void CreateContactUISettings()
        {

            // ---------------------------------------------------------------------
            // Werte: Lehrling
            // ---------------------------------------------------------------------

            // ---------------------------------------------------------------------
            // Werte: Mitarbeiter
            // ---------------------------------------------------------------------

            // ---------------------------------------------------------------------
            // Werte: Kunde
            // ---------------------------------------------------------------------
            Protokoll.Visible = false;
            Notiz.Visible = false;
            KundeBearbeiten.Visible = false;

        }


        //----------------------------------------------------------------------
        // Events
        //----------------------------------------------------------------------


        // ---------------------------------------------------------------------
        // Werte: Lehrling
        // ---------------------------------------------------------------------

        private void BtnSpeichernL_Click(object sender, EventArgs e)
        {
            try
            {
                var trainee = new DtoTrainee
                {

                    Salutation = CmbAnredeL.Text,
                    FirstName = TxtVornameL.Text,
                    LastName = TxtNachnameL.Text,
                    DateOfBirth = DtpGeburtsdatumL.Value,
                    Gender = CmbGeschlechtL.Text,
                    SocialSecurityNumber = TxtAhvnummerL.Text,
                    PhoneNumberPrivate = TxtTelefonprivatL.Text,
                    PhoneNumberMobile = TxtMobiltelefonnummerL.Text,
                    PhoneNumberBuisness = TxtGeschaeftL.Text,
                    EmailPrivat = TxtEmailL.Text,
                    Status = CbStatusL.Checked,
                    Nationality = CmbNationalitätL.Text,
                    Street = TxtStrasseL.Text,
                    StreetNumber = TxtHausnummerL.Text,
                    ZipCode = TxtPostleitzahlL.Text,
                    Place = TxtWohnortL.Text,
                    Type = TabLehrling.Text,
                    Department = CmbAbteilungL.Text,
                    StartDate = DtpEintrittL.Value,
                    EndDate = DtpAustrittL.Value,
                    Employment = int.Parse(CmbBeschaeftigungsgradL.Text),
                    Role = cmbRolle.Text,
                    CadreLevel = 0,
                    TraineeYears = int.Parse(CmbLehrjahreL.Text),
                };

                var (ok, msg) = Controller.CreateTrainee(trainee);

                //MessageBox
                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }
        }

        // ---------------------------------------------------------------------
        // Werte: Mitarbeiter
        // ---------------------------------------------------------------------

        private void BtnErstelleMitarbeiter_Click_1(object sender, EventArgs e)
        {
            try
            {
                var employee = new DtoEmployee
                {


                    //Persönliche Angaben
                    Salutation = CmbAnredeM.Text,
                    Title = CmbTitelM.Text,
                    FirstName = TxtVornameM.Text,
                    LastName = TxtNachnameM.Text,
                    DateOfBirth = DtpGeburtsdatumM.Value,
                    Gender = CmbGeschlechtM.Text,
                    SocialSecurityNumber = TxtAhvnummerM.Text,
                    Nationality = CmbNationalitätM.Text,

                    //Adresse + Kontakt
                    Street = TxtStrasseM.Text,
                    StreetNumber = TxtHausnummerM.Text,
                    ZipCode = TxtPostleitzahlM.Text,
                    Place = TxtWohnortM.Text,
                    EmailPrivat = TxtEmailM.Text,
                    PhoneNumberPrivate = TxtTelefonprivatM.Text,
                    PhoneNumberMobile = TxtMobiltelefonnummerM.Text,
                    PhoneNumberBuisness = TxtGeschaeftM.Text,

                    //Beschäftigungsdaten
                    CadreLevel = int.Parse(CmbKaderstufenM.Text),
                    Department = CmbAbteilungM.Text,
                    Role = CmbRolleM.Text,
                    Employment = int.Parse(CmbBeschaeftigungsgradM.Text),

                    StartDate = DtpEintrittM.Value,
                    EndDate = DtpAustrittM.Value,

                    Status = CbStatusM.Checked,

                    // Meta
                    Type = TabMitarbeiter.Text,
                };

                var (ok, msg) = Controller.CreateEmployee(employee);

                // MessageBox
                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }
        }

        // ---------------------------------------------------------------------
        // Werte: Kunde
        // ---------------------------------------------------------------------
        private void BtnSpeichernK_Click_1(object sender, EventArgs e)
        {
            try
            {
                var customer = new DtoCustomer
                {
                    //Persönliche Angaben
                    Salutation = CmbAnredeK.Text,
                    Title = CmbTitelK.Text,
                    FirstName = TxtVornameK.Text,
                    LastName = TxtNachnameK.Text,


                    //Adresse + Kontakt
                    Street = TxtStrasseK.Text,
                    StreetNumber = TxtHausnummerK.Text,
                    ZipCode = TxtPostleitzahlK.Text,
                    Place = TxtWohnortK.Text,
                    PhoneNumberBuisness = TxtTelefoneK.Text,

                    //Firma
                    CompanyName = TxtFirmennameK.Text,
                    CompanyContact = TxtGeschaeftK.Text,

                    //Administratives
                    CustomerType = Convert.ToChar(CmbKundentypK.Text),
                    Status = CmbStatusK.Checked,

                    // Meta
                    Type = Customer.Text,
                };
                var (ok, msg) = Controller.CreateCustomer(customer);

                // MessageBox
                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }

        }


        // ---------------------------------------------------------------------
        // Editieren
        // ---------------------------------------------------------------------

        private void BearbeitenContactUISettings(string type)
        {
            BtnSpeichernK.Visible = false;
            if (type == "Kunde")
            {
                PERSON.SelectedIndex = 0; // Kunden
                PERSON.TabPages.Remove(TabMitarbeiter);
                PERSON.TabPages.Remove(TabLehrling);
            }
            if (type == "Mitarbeiter") PERSON.SelectedIndex = 1; // Mitarbeiter
            if (type == "Lehrling") PERSON.SelectedIndex = 2; // Lehrling
        }

        //----------------------------------------------------------------------
        // Kontakten abrufen
        //----------------------------------------------------------------------

        private void GetContactData(Guid id, string type)
        {
            if (type == "Kunde")
            {
                var customer = Controller.GetCustomer(id);
                //Persönliche Angaben
                CmbAnredeK.Text = customer.Salutation;
                CmbTitelK.Text = customer.Title;
                TxtVornameK.Text = customer.FirstName;
                TxtNachnameK.Text = customer.LastName;
                //Adresse + Kontakt
                TxtStrasseK.Text = customer.Street;
                TxtHausnummerK.Text = customer.StreetNumber;
                TxtPostleitzahlK.Text = customer.ZipCode;
                TxtWohnortK.Text = customer.Place;
                TxtTelefoneK.Text = customer.PhoneNumberBuisness;
                //Firma
                TxtFirmennameK.Text = customer.CompanyName;
                TxtGeschaeftK.Text = customer.CompanyContact;
                //Administratives
                CmbKundentypK.Text = Convert.ToString(customer.CustomerType);
                CmbStatusK.Checked = customer.Status;
                // Privilege Stufe
                Customer.Text = customer.Type;
            }
        }

        //----------------------------------------------------------------------
        // Events
        //----------------------------------------------------------------------


        // ---------------------------------------------------------------------
        // Werte: Lehrling   
        // ---------------------------------------------------------------------


        // ---------------------------------------------------------------------
        // Werte: Mitarbeiter
        // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Werte: Kunde
        // ---------------------------------------------------------------------





    }
}
