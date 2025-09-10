
using System;
using System.Windows.Forms;
using ContactManager.Core.Services;

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
        // Werte: Lehrling
        // ---------------------------------------------------------------------

        private void BtnSpeichernL_Click(object sender, EventArgs e)
        {

            var trainee = new DtoTrainee
            {

                Salutation = CmbAnredeL.Text,
                FirstName = TxtVornameL.Text,
                LastName = TxtNachnameL.Text,
                DateOfBirth = DtpGeburtsdatumL.Value,
                Gender = CmbGeschlechtL.Text,
                Title = CmbTitelL.Text,
                SocialSecurityNumber = TxtAhvnummerL.Text,
                PhoneNumberPrivate = TxtTelefonprivatL.Text,
                PhoneNumberMobile = TxtMobiltelefonnummerL.Text,
                PhoneNumberBuisness = TxtGeschaeftL.Text,
                EmailPrivat = TxtEmailL.Text,
                Status = CbStatusL.Checked,
                Nationality = CmbNationalitätL.Text,
                Street = TxtStrasseL.Text,
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

            //MessageBox kann hier aufgerufen werden
            // Variable: ok , msg / Text = Message / True or False = ok 


        }

        private void cmbRolle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ---------------------------------------------------------------------
        // Werte: Mitarbeiter
        // ---------------------------------------------------------------------

        private void CmdSpeichernM_Click(object sender, EventArgs e)
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
                ZipCode = TxtPostleitzahlM.Text,
                Place = TxtWohnortM.Text,
                EmailPrivat = TxtEmailM.Text,
                PhoneNumberPrivate = TxtTelefonprivatM.Text,
                PhoneNumberMobile = TxtMobiltelefonnummerM.Text,
                PhoneNumberBuisness = TxtGeschaeftM.Text,

                //Beschäftigungsdaten
                CadreLevel = 0,
                Department = CmbAbteilungM.Text,
                Role = cmbRolle.Text,
                Employment = int.Parse(CmbBeschaeftigungsgradL.Text),

                StartDate = DtpEintrittM.Value,
                EndDate = DtpAustrittM.Value,

                Status = CbStatusM.Checked,

            };
        }

        // ---------------------------------------------------------------------
        // Werte: Kunde
        // ---------------------------------------------------------------------
        private void BtnSpeichernK_Click_1(object sender, EventArgs e)
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
                PhoneNumberBuisness = TxtGeschaeftK.Text,

                //Firma
                CompanyName = TxtFirmennameK.Text,
                CompanyContact = TxtFirmenkontaktK.Text,

                //Administratives
                // CustomerType = customerType,             
                Status = CmbStatusK.Checked,

                // Meta
                Type = "Kunde"

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CmdNotizK_Click(object sender, EventArgs e)
        {

        }
    }


}
