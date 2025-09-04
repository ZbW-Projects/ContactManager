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
        }

        // ---------------------------------------------------------------------
        // Trainee Werte 
        // ---------------------------------------------------------------------



        // ---------------------------------------------------------------------
        // Aktionen
        // ---------------------------------------------------------------------

        private void BtnSpeichernL_Click(object sender, EventArgs e)
        {

            DtoTrainee trainee = new DtoTrainee()
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
                StartDate = dtpEintritt.Value,
                EndDate = dtpAustritt.Value,
                Employment = int.Parse(CmbBeschaeftigungsgradL.Text),
                Role = cmbRolle.Text,
                CadreLevel = 0,
                TraineeYears = int.Parse(CmbLehrjahreL.Text),
            };

            Controller.CreateTrainee(trainee);

        }



    }


}
