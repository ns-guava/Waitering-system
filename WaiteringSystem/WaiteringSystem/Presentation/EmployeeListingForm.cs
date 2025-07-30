using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem.Business;
using WaiteringSystem.Data;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WaiteringSystem.Business.Role;

namespace WaiteringSystem.Presentation
{
    public enum Formstates
    {
        View = 0,
        Add = 1,
        Edit = 2,
        Delete = 3,

    }

    public partial class EmployeeListingForm : Form
    { 
        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Employee> employees;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;

        private Formstates states;
        private Employee employee;
        #endregion

        #region property methods

        public Role.RoleType RoleValue
        {

            set { roleValue = value; }

        }

        #endregion

        #region Constructor
        public EmployeeListingForm()
        {
            InitializeComponent();
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            this.FormClosed += EmployeeListingForm_FormClosed;

            states = Formstates.View;
        }



        public EmployeeListingForm(EmployeeController empController)
        {

            InitializeComponent();
            employeeController = empController;
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;

        }
        #endregion

        #region Events
        private void EmployeeListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
        
        private void EmployeeListingForm_Load(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
        }

        private void EmployeeListingForm_Activated(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
            setUpEmployeeListView();
            ShowAll(false,roleValue);
        }
        #endregion

        #region ListView set up
        public void setUpEmployeeListView()
        {
            ListViewItem employeeDetails;
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            employees = null;
            employeeListView.Clear();

            employeeListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(1, "EMPID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(2, "Name", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);


            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    employees = employeeController.AllEmployees; listLabel.Text = "Listing of all employees";
                    employeeListView.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Headwaiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Headwaiter);
                    listLabel.Text = "Listing of all Headwaiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "Salary", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Waiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Waiter);
                    listLabel.Text = "Listing of all Waiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;

                case Role.RoleType.Runner:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Runner);
                    listLabel.Text = "Listing of all Runners";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;
            }




            foreach (Employee employee in employees)
            {
                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                employeeDetails.SubItems.Add(employee.EmployeeID.ToString());
                employeeDetails.SubItems.Add(employee.Name.ToString());
                employeeDetails.SubItems.Add(employee.Telephone.ToString());
                // Do the same for EmpID, Name and Phone
                switch (employee.role.getRoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.getRate.ToString());
                        employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                        employeeDetails.SubItems.Add(waiter.getTips.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.getRate.ToString());
                        employeeDetails.SubItems.Add(runner.getShifts.ToString());
                        employeeDetails.SubItems.Add(runner.getTips.ToString());
                        break;

                }

                employeeListView.Items.Add(employeeDetails);


            }

            employeeListView.Refresh();
            employeeListView.GridLines = true;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value, Role.RoleType roleType)
        {
            txtBoxID.Visible = value;
            lblID.Visible = value;

            txtBoxEMPID.Visible = value;
            lblEMPID.Visible = value;

            txtBoxName.Visible = value;
            lblName.Visible = value;

            txtBoxPay.Visible = value;
            lblPay.Visible = value;

            txtBoxPhone.Visible = value;
            lblPhone.Visible = value;

            txtBoxShifts.Visible = value;
            lblShifts.Visible = value;

            if (states == Formstates.View)
            {
                btnSubmit.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                btnSubmit.Visible = value;
                btnCancel.Visible = value;
            }

            if (roleType == Role.RoleType.Headwaiter)
            {
                txtBoxShifts.Visible = false;
                lblShifts.Visible = false;
            }
        }

        private void ClearAll()
        {
            txtBoxID.Clear();
            txtBoxEMPID.Clear();
            txtBoxName.Clear();
            txtBoxPay.Clear();
            txtBoxPhone.Clear();
            txtBoxShifts.Clear();
        }

        private void EnableEntries(bool value)
        {
            if (states == Formstates.Edit && value)
            {
                txtBoxID.Enabled = !value;
                txtBoxEMPID.Enabled = !value;

            }
            else
            {
                txtBoxID.Enabled = value;
                txtBoxEMPID.Enabled = value;
            }

            txtBoxPhone.Enabled = value;
            txtBoxPay.Enabled = value;
            txtBoxShifts.Enabled = value;

            if (states == Formstates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
        }
        #endregion

        private void PopulateTextBoxes (Employee employee)
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;

            txtBoxID.Text = employee.ID;
            txtBoxEMPID.Text = employee.EmployeeID;
            txtBoxName.Text = employee.Name;
            txtBoxPhone.Text = employee.Telephone;

            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(employee.role);
                    txtBoxPay.Text = Convert.ToString(headW.SalaryAmount);
                    break;

                case Role.RoleType.Waiter:
                    waiter = (Waiter)(employee.role);
                    txtBoxPay.Text = Convert.ToString(waiter.getRate);
                    txtBoxShifts.Text = Convert.ToString(waiter.getShifts);
                    break;

                case Role.RoleType.Runner:
                    runner = (Runner)(employee.role);
                    txtBoxPay.Text = Convert.ToString(runner.getRate);
                    txtBoxShifts.Text = Convert.ToString(runner.getShifts);
                    break;
            }

        }

        private void PopulateObject()
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            /*employee = new Employee(roleType);*/
            employee.ID = txtBoxID.Text;
            employee.EmployeeID = txtBoxEMPID.Text;
            employee.Name = txtBoxName.Text;
            employee.Telephone = txtBoxPhone.Text;

            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(employee.role);
                    headW.SalaryAmount = decimal.Parse(txtBoxPay.Text);
                    break;
                case Role.RoleType.Waiter:
                    waiter = (Waiter)(employee.role);
                    waiter.getRate = decimal.Parse(txtBoxPay.Text);
                    waiter.getShifts = int.Parse(txtBoxShifts.Text);
                    //  waiter.Tips = decimal.Parse(tipsTextBox.Text);
                    break;
                case Role.RoleType.Runner:
                    runner = (Runner)(employee.role);
                    runner.getRate = decimal.Parse(txtBoxPay.Text);
                    runner.getShifts = int.Parse(txtBoxShifts.Text);
                    break;
            }
        }

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true, roleValue);

            states = Formstates.Edit;

            EnableEntries(false);

            if (employeeListView.SelectedItems.Count > 0) 
            {
                employee = employeeController.Find(employeeListView.SelectedItems[0].Text);
                PopulateTextBoxes(employee);
            }
        
           
    }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            states = Formstates.Edit;
            EnableEntries(true);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PopulateObject();

            if (states == Formstates.Edit)
            {
                employeeController.DataMaintenance(employee, DB.DBOperation.Edit);

            }
            else if (states == Formstates.Delete) 
            {
                employeeController.DataMaintenance(employee, DB.DBOperation.Delete);
            }

            employeeController.FinalizeChanges(employee);
            ClearAll();
            states = Formstates.View;
            ShowAll(false, roleValue);
            setUpEmployeeListView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            states = Formstates.Delete;
            EnableEntries(false);
        }
    }
}
