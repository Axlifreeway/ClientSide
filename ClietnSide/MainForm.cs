using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClietnSide
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void ClickButtonAddOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано.. реализовать..");
        }

        public void ClickButtonRemoveOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        private bool IsCorrectOrganisation(string organisation)
        {
            return true;
        }

        public void ClickButtonGetOrganisations(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonAddContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано. реализовать.");
        }

        public void ClickButtonRemoveContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public bool IsCorrectContract(string contract)
        {
            return true;
        }

        public void ClickButtonGetContracts(object sender, EventArgs e /*DateTime start, DateTime end*/)
        {
            MessageBox.Show("Не реализовано");
        }


        public void ClickButtonAddVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано... реализовать...");
        }

        public void ClickButtonRemoveVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public bool isCorrectVaccination(string Vaccination)
        {
            return true;
        }

        public void ClickButtonGetVacciantions(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonAddInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано.... реализовать....");
        }

        public void ClickButtonRemoveInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonEditInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public bool isCorrectInspection(string Inspection)
        {
            return true;
        }

        public void ClickButtonGetInspections(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowOrganisation(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowContract(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowVaccination(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        public void ClickButtonShowInspection(object sender, EventArgs e)
        {
            MessageBox.Show("Не реализовано");
        }

        private void ClickContractsShow(object sender, EventArgs e)
        {
            HideAll();
            ContractAdd.Visible = true;
            ContractRemove.Visible = true;
            ContractEdit.Visible = true;
            ContractsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickOrganisationShow(object sender, EventArgs e)
        {
            HideAll();
            OrganisationAdd.Visible = true;
            OrganisationRemove.Visible = true;
            OrganisationEdit.Visible = true;
            OrganisationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickVaccinationShow(object sender, EventArgs e)
        {
            HideAll();
            VaccinationAdd.Visible = true;
            VaccinationRemove.Visible = true;
            VaccinationEdit.Visible = true;
            VaccinationsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void ClickInspectionShow(object sender, EventArgs e)
        {
            HideAll();
            InspectionAdd.Visible = true;
            InspectionRemove.Visible = true;
            InspectionEdit.Visible = true;
            InspectionsGet.Visible = true;
            dataGrid.Visible = true;
        }

        private void HideAll()
        {
            ContractAdd.Visible = false;
            ContractRemove.Visible = false;
            ContractEdit.Visible = false;
            ContractsGet.Visible = false;
            dataGrid.Visible = false;
            OrganisationAdd.Visible = false;
            OrganisationRemove.Visible = false;
            OrganisationEdit.Visible = false;
            OrganisationsGet.Visible = false;
            VaccinationAdd.Visible = false;
            VaccinationRemove.Visible = false;
            VaccinationEdit.Visible = false;
            VaccinationsGet.Visible = false;
            InspectionAdd.Visible = false;
            InspectionRemove.Visible = false;
            InspectionEdit.Visible = false;
            InspectionsGet.Visible = false;
        }
    }
}
