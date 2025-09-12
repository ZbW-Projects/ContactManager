
using ContactManager.Core.Model;
using ContactManager.Core.Services;
using ContactManager.View.Forms.Components;
using System;
using System.Windows.Forms;

namespace ContactManager.View.Forms
{
    public partial class Details : Form
    {

        public Details()
        {
            InitializeComponent();
            Controller.SpinData();
        }

        // ---------------------------------------------------------------------
        // Aktionen
        // ---------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Erstellen
        // ---------------------------------------------------------------------

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
                    Type = TabKunde.Text,
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

        // -------------------------------------------------------------------------
        // Editieren
        // -------------------------------------------------------------------------

        // ---------------------------------------------------------------------
        // Werte: Lehrling
        // ---------------------------------------------------------------------
    }

}
