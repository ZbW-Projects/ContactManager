using ContactManager.Core.Model;
using ContactManager.Core.Services;
using ContactManager.View.Forms.Components;
using System;
using System.Data;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager.View.Forms
{
    /// Details-Form zur Erstellung und Bearbeitung von Kontakten (Kunde, Mitarbeiter, Lehrling).

    public partial class Details : Form
    {
        #region Konstruktoren (Start)

        /// Szenario 1: Kontakt erstellen.

        public Details()
        {
            InitializeComponent();
            // Controller.SpinData();
            CreateContactUISettings();
        }


        /// Szenario 2: Kontakt bearbeiten.
        /// <param name="id">Kontakt-Id</param>
        /// <param name="type">Kontakt-Typ ("Kunde" | "Mitarbeiter" | "Lehrling")</param>
        public Details(Guid id, string type)
        {
            InitializeComponent();
            // Controller.SpinData();
            BearbeitenContactUISettings(type);
            GetContactDataL(id, type);
            GetContactDataM(id, type);
            GetContactDataK(id, type);
        }

        #endregion Konstruktoren (End)

        #region UI-Setup (Start)

        private void CreateContactUISettings()
        {
            // Kunde-spezifische Bereiche beim Erstellen ausblenden
            Protokoll.Visible = false;
            Notiz.Visible = false;
            // Fehler KundeBearbeiten.Visible = false;
        }

        private void BearbeitenContactUISettings(string type)
        {
            CmdSpeichernK.Visible = false;

            if (type == "Kunde")
            {
                PERSON.SelectedIndex = 0; // Kunde
                PERSON.TabPages.Remove(TabEmployee);
                PERSON.TabPages.Remove(TabLehrling);
            }
            if (type == "Mitarbeiter") PERSON.SelectedIndex = 1; // Mitarbeiter
            if (type == "Lehrling") PERSON.SelectedIndex = 2;    // Lehrling
        }

        #endregion UI-Setup (End)

        #region Events: Load Kunde (Start)

        /// Laedt Kontakt-Daten in die UI.

        private void GetContactDataK(Guid id, string type)
        {
            if (type == "Kunde")
            {
                var customer = Controller.GetCustomer(id);

                // Persoenliche Angaben
                CmbSalutationK.Text = customer.Salutation;
                CmbTitleK.Text = customer.Title;
                TxtFirstnameK.Text = customer.FirstName;
                TxtLastNameK.Text = customer.LastName;
                TxtPhoneNumberBuisnessK.Text = customer.PhoneNumberBuisness;

                // Firma + Kontakt
                TxtCompanyNameK.Text = customer.CompanyName;
                TxtCompanycontactK.Text = customer.CompanyContact;
                TxtStreetK.Text = customer.Street;
                TxtStreetNumberK.Text = customer.StreetNumber;
                TxtZipcodeK.Text = customer.ZipCode;
                TxtPlaceK.Text = customer.Place;

                // Administratives
                CmbStatusK.Checked = customer.Status;
                CmbCustomerTypeK.Text = Convert.ToString(customer.CustomerType);

                // Privileg/Typ
                TabKunde.Text = customer.Type;

                //Protokoll
                // ProtokollListeK

                //Notiz
                //TxtNoteK
                // TxtOwnerK
                //BtnNotizSpeichernK
            }
        }

        #endregion Events: Load Kunde (Start)

        #region Events: Load Mitarbeiter (Start)

        /// Laedt Kontakt-Daten in die UI.

        private void GetContactDataM(Guid id, string type)
        {
            if (type == "Mitarbeiter")
            {

                var employee = Controller.GetEmployee(id);

                // Persönliche Angaben
                CmbSalutationM.Text = employee.Salutation;
                CmbTitleM.Text = employee.Title;
                TxtFirstNameM.Text = employee.FirstName;
                TxtLastNameM.Text = employee.LastName;
                DtpDateOfBirthM.Value = employee.DateOfBirth;
                CmbGenderM.Text = employee.Gender;
                TxtSocialSecurityNumberM.Text = employee.SocialSecurityNumber;
                CmbNationalityM.Text = employee.Nationality;

                // Adresse + Kontakt 
                TxtStreetM.Text = employee.Street;
                TxtStreetNumberM.Text = employee.StreetNumber;
                TxtZipCodeM.Text = employee.ZipCode;
                TxtPlaceM.Text = employee.Place;
                TxtEmailPrivatM.Text = employee.EmailPrivat;
                TxtPhoneNumberPrivateM.Text = employee.PhoneNumberPrivate;
                TxtPhoneNumberMobileM.Text = employee.PhoneNumberMobile;
                TxtPhoneNumberBusinessM.Text = employee.PhoneNumberBuisness;

                // Beschäftigungsdaten 
                CmbCadreLevelM.Text = Convert.ToString(employee.CadreLevel);
                CmbDepartmentM.Text = employee.Department;
                CmbRoleM.Text = employee.Role;
                CmbEmploymentM.Text = Convert.ToString(employee.Employment);

                DtpStartDateM.Value = employee.StartDate;
                DtpEndDateM.Value = employee.EndDate;

                CbStatusM.Checked = employee.Status;
                TabEmployee.Text = employee.Type;


            }
        }

        #endregion Events: Load Mitarbeiter (Start)

        #region Events: Load Trainee (Start)

        /// Laedt Kontakt-Daten in die UI.

        private void GetContactDataL(Guid id, string type)
        {
            if (type == "Lehrling")
            {
                var trainee = Controller.GetEmployee(id);

                // Personal Information
                CmbSalutationL.Text = trainee.Salutation;
                TxtFirstNameL.Text = trainee.FirstName;
                TxtLastNameL.Text = trainee.LastName;
                DtpDateOfBirthL.Value = trainee.DateOfBirth;
                CmbGenderL.Text = trainee.Gender;
                TxtSocialSecurityNumberL.Text = trainee.SocialSecurityNumber;
                CmbNationalityL.Text = trainee.Nationality;
              
                // Address & Contact
                TxtStreetL.Text = trainee.Street;
                TxtStreetNumberL.Text = trainee.StreetNumber;
                TxtZipCodeL.Text = trainee.ZipCode;
                TxtCityL.Text = trainee.Place;
                TxtPhonePrivateL.Text = trainee.PhoneNumberPrivate;
                TxtPhoneMobileL.Text = trainee.PhoneNumberMobile;
                TxtEmailL.Text = trainee.EmailPrivat;

                // Administrative
                CbStatusL.Checked = trainee.Status;

                // Education / Employment
                CmbDepartmentL.Text = trainee.Department;
                CmbRoleL.Text = trainee.Role;
                CmbEmploymentRateL.Text = Convert.ToString(trainee.Employment);

                // Entry / Exit
                DtpStartDateL.Value = trainee.StartDate;
                DtpEndDateL.Value = trainee.EndDate;

                // Privileg/Typ
                TabLehrling.Text = trainee.Type;

            }
        }

        #endregion Events: Load Trainee (Start)

        #region Events: Create Lehrling (Start)

        /// Speichert einen Lehrling.

        private void BtnSpeichernL_Click(object sender, EventArgs e)
        {
            try
            {
                var trainee = new DtoTrainee
                {
                    Salutation = CmbSalutationL.Text,
                    FirstName = TxtFirstNameL.Text,
                    LastName = TxtLastNameL.Text,
                    DateOfBirth = DtpDateOfBirthL.Value,
                    Gender = CmbGenderL.Text,
                    SocialSecurityNumber = TxtSocialSecurityNumberL.Text,
                    PhoneNumberPrivate = TxtPhonePrivateL.Text,
                    PhoneNumberMobile = TxtPhoneMobileL.Text,

                    EmailPrivat = TxtEmailL.Text,
                    Status = CbStatusL.Checked,
                    Nationality = CmbNationalityL.Text,
                    Street = TxtStreetL.Text,
                    StreetNumber = TxtStreetNumberL.Text,
                    ZipCode = TxtZipCodeL.Text,
                    Place = TxtCityL.Text,
                    Type = TabLehrling.Text,
                    Department = CmbDepartmentL.Text,
                    StartDate = DtpStartDateL.Value,
                    EndDate = DtpEndDateL.Value,
                    Employment = int.Parse(CmbEmploymentRateL.Text),
                    Role = CmbRoleL.Text,
                    CadreLevel = 0,
                    TraineeYears = int.Parse(CmbLehrjahreL.Text),
                };

                var (ok, msg) = Controller.CreateTrainee(trainee);

                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }
        }

        #endregion Events: Create Lehrling (End)

        #region Events: Create Mitarbeiter (Start)

        /// Speichert einen Mitarbeiter.

        private void BtnErstelleMitarbeiter_Click_1(object sender, EventArgs e)
        {
            try
            {
                var employee = new DtoEmployee
                {
                    // Persoenliche Angaben
                    Salutation = CmbSalutationM.Text,
                    Title = CmbTitleM.Text,
                    FirstName = TxtFirstNameM.Text,
                    LastName = TxtLastNameM.Text,
                    DateOfBirth = DtpDateOfBirthM.Value,
                    Gender = CmbGenderM.Text,
                    SocialSecurityNumber = TxtSocialSecurityNumberM.Text,
                    Nationality = CmbNationalityM.Text,

                    // Adresse + Kontakt
                    Street = TxtStreetM.Text,
                    StreetNumber = TxtStreetNumberM.Text,
                    ZipCode = TxtZipCodeM.Text,
                    Place = TxtPlaceM.Text,
                    EmailPrivat = TxtEmailPrivatM.Text,
                    PhoneNumberPrivate = TxtPhoneNumberPrivateM.Text,
                    PhoneNumberMobile = TxtPhoneNumberMobileM.Text,
                    PhoneNumberBuisness = TxtPhoneNumberBusinessM.Text,

                    // Beschaeftigungsdaten
                    CadreLevel = int.Parse(CmbCadreLevelM.Text),
                    Department = CmbDepartmentM.Text,
                    Role = CmbRoleM.Text,
                    Employment = int.Parse(CmbEmploymentM.Text),
                    StartDate = DtpStartDateM.Value,
                    EndDate = DtpEndDateM.Value,

                    Status = CbStatusM.Checked,

                    // Meta
                    Type = TabEmployee.Text,
                };

                var (ok, msg) = Controller.CreateEmployee(employee);

                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }
        }

        #endregion Events: Create Mitarbeiter (End)

        #region Events: Create Kunde (Start)


        /// Speichert einen Kunden.

        private void BtnSpeichernK_Click_1(object sender, EventArgs e)
        {
            try
            {
                var customer = new DtoCustomer
                {
                    // Persoenliche Angaben
                    Salutation = CmbSalutationK.Text,
                    Title = CmbTitleK.Text,
                    FirstName = TxtFirstnameK.Text,
                    LastName = TxtLastNameK.Text,

                    // Adresse + Kontakt
                    Street = TxtStreetK.Text,
                    StreetNumber = TxtStreetNumberK.Text,
                    ZipCode = TxtZipcodeK.Text,
                    Place = TxtPlaceK.Text,
                    PhoneNumberBuisness = TxtPhoneNumberBuisnessK.Text,

                    // Firma
                    CompanyName = TxtCompanyNameK.Text,
                    CompanyContact = TxtCompanycontactK.Text,

                    // Administratives
                    CustomerType = Convert.ToChar(CmbCustomerTypeK.Text),
                    Status = CmbStatusK.Checked,

                    // Meta
                    Type = TabKunde.Text,
                };

                var (ok, msg) = Controller.CreateCustomer(customer);

                if (!ok) InputBox.Error(msg);
                else InputBox.Info(msg);
            }
            catch (ArgumentException ex) { InputBox.Warning(ex.Message); }
            catch (FormatException ex) { InputBox.Warning(ex.Message); }
            catch (Exception ex) { InputBox.Error(ex.Message); }
        }

        #endregion Events: Create Kunde (End)

        private void TxtMobiltelefonnummerL_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrpFirmaK_Enter(object sender, EventArgs e)
        {

        }

        private void TxtOwnerK_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CmbAnredeL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
