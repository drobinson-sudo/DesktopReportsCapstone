using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopReportsCapstone
{
    public partial class Dashboard : Form
    {
        //Instantiate variables for use throughout this form.
        List<Report> reports = new List<Report>();
        Report currentReport;
        Report newReport = new Report();
        DateTime currentDate;
        Color editModeColor = ColorTranslator.FromHtml("#EBE8E1");
        Color readModeColor = ColorTranslator.FromHtml("#E6E3DA");        

        bool editMode = false;
        bool createMode = false;


        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }


        //Keep the list of the listbox up to date, by rebinding it to the datasource.
        private void UpdateBinding()
        {
            lsbReportDates.DataSource = reports;
            lsbReportDates.DisplayMember = "DateCreated";
        }

        //Determine what shows in the text box data entry area - either blank for new entries, 
        //or the entry corresponding to the selected date.
        private void SetContentArea()
        {
            if (createMode)
            {
                txtReportContent.Text = "";
                lblDateEdited.Text = currentDate.ToString("yyyy-MM-dd");
            }
            else
            {
                currentReport = reports[lsbReportDates.SelectedIndex];
                txtReportContent.Text = currentReport.Content;
                //DateTime? editDate = currentReport.DateLastEdit;
                //if (editDate != null )                                   
                //    lblDateEdited.Text = editDate.ToString();
                if (currentReport.DateLastEdit > System.DateTime.MinValue)
                    lblDateEdited.Text = currentReport.DateLastEdit.ToString("yyyy-MM-dd");
                else
                    lblDateEdited.Text = "";
            }
            
        }

        //Hide and Show buttons depending on which functions are available at any given point.
        //Helps to keep the UserInterface clean and more intuitive than showing all controls always.
        private void SetSaveCancelButtons()
        {
            if (createMode || editMode)
            {
                btnCancel.Show();
                btnSave.Show();
                btnEdit.Hide();
                txtReportContent.ReadOnly = false;
                txtReportContent.Focus();
                txtReportContent.BackColor = editModeColor;
            }
            else
            {
                btnCancel.Hide();
                btnSave.Hide();
                btnEdit.Show();
                txtReportContent.ReadOnly = true;
                txtReportContent.BackColor = readModeColor;
            }
        }

        //Calls the stored procedure in Azure Database to update the current record.
        //The DataAccess class is a created class to use Dapper ORM to communicate with 
        //the database.
        private void SaveEdit()
        {
            currentReport.Content = txtReportContent.Text;
            currentReport.DateLastEdit = currentDate;
            DataAccess db = new DataAccess();
            db.UpdateReport(currentReport);
            MessageBox.Show("Changes were saved successfully!");
            lblDateEdited.Text = "";
            
        }


        //Call the stored procedure in Azure Database to insert a new record into the table.
        //The DataAccess class is a created class to use Dapper ORM to communicate with 
        //the database.
        private void SaveNew()
        {
            newReport.DateCreated = currentDate;
            newReport.Content = txtReportContent.Text;
            DataAccess db = new DataAccess();
            db.InsertReport(newReport);
            MessageBox.Show("New report saved successfully!");
            lblDateEdited.Text = "";
            reports = db.GetReports();
            UpdateBinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Calls a stored procedure in Azure Database to return all records from the table in reverse 
            //chronological order. The called function returns the records as objects of the class Report.
            DataAccess db = new DataAccess();
            reports = db.GetReports();

            UpdateBinding();

            SetContentArea();
            SetSaveCancelButtons();
        }

        //Change text box content as new dates are selected.
        private void lsbReportDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetContentArea();
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            createMode = true;
            SetSaveCancelButtons();
            txtReportContent.Text = "";
            lsbReportDates.SelectedIndex = -1;
            currentDate = DateTime.Now;
            lblDateEdited.Text = currentDate.ToString("yyyy-MM-dd");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode = true;
            SetSaveCancelButtons();
            currentDate = DateTime.Now;
            lblDateEdited.Text = currentDate.ToString("yyyy-MM-dd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editMode)
                SaveEdit();
            else if (createMode)
                SaveNew();
             
            createMode = false;
            editMode = false;
            SetSaveCancelButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes will not be saved.");
            txtReportContent.Text = currentReport.Content;
            lblDateEdited.Text = "";
            createMode = false;
            editMode = false;
            SetSaveCancelButtons();          
        }
    }
}
