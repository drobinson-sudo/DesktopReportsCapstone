namespace DesktopReportsCapstone
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProgressReports = new System.Windows.Forms.Label();
            this.lsbReportDates = new System.Windows.Forms.ListBox();
            this.txtReportContent = new System.Windows.Forms.TextBox();
            this.lblDateEdited = new System.Windows.Forms.Label();
            this.lblDescDateEdited = new System.Windows.Forms.Label();
            this.btnNewReport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProgressReports
            // 
            this.lblProgressReports.AutoSize = true;
            this.lblProgressReports.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.lblProgressReports.Location = new System.Drawing.Point(22, 48);
            this.lblProgressReports.Name = "lblProgressReports";
            this.lblProgressReports.Size = new System.Drawing.Size(226, 33);
            this.lblProgressReports.TabIndex = 0;
            this.lblProgressReports.Text = "Progress Reports";
            // 
            // lsbReportDates
            // 
            this.lsbReportDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.lsbReportDates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbReportDates.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbReportDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.lsbReportDates.FormattingEnabled = true;
            this.lsbReportDates.ItemHeight = 21;
            this.lsbReportDates.Location = new System.Drawing.Point(69, 137);
            this.lsbReportDates.Name = "lsbReportDates";
            this.lsbReportDates.Size = new System.Drawing.Size(154, 357);
            this.lsbReportDates.TabIndex = 1;
            this.lsbReportDates.SelectedIndexChanged += new System.EventHandler(this.lsbReportDates_SelectedIndexChanged);
            // 
            // txtReportContent
            // 
            this.txtReportContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.txtReportContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.txtReportContent.Location = new System.Drawing.Point(267, 137);
            this.txtReportContent.Multiline = true;
            this.txtReportContent.Name = "txtReportContent";
            this.txtReportContent.ReadOnly = true;
            this.txtReportContent.Size = new System.Drawing.Size(482, 368);
            this.txtReportContent.TabIndex = 2;
            // 
            // lblDateEdited
            // 
            this.lblDateEdited.AutoSize = true;
            this.lblDateEdited.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEdited.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.lblDateEdited.Location = new System.Drawing.Point(657, 103);
            this.lblDateEdited.Name = "lblDateEdited";
            this.lblDateEdited.Size = new System.Drawing.Size(0, 21);
            this.lblDateEdited.TabIndex = 3;
            // 
            // lblDescDateEdited
            // 
            this.lblDescDateEdited.AutoSize = true;
            this.lblDescDateEdited.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescDateEdited.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.lblDescDateEdited.Location = new System.Drawing.Point(652, 85);
            this.lblDescDateEdited.Name = "lblDescDateEdited";
            this.lblDescDateEdited.Size = new System.Drawing.Size(97, 16);
            this.lblDescDateEdited.TabIndex = 4;
            this.lblDescDateEdited.Text = "Date Last Edited";
            // 
            // btnNewReport
            // 
            this.btnNewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.btnNewReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.btnNewReport.Location = new System.Drawing.Point(267, 45);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(114, 41);
            this.btnNewReport.TabIndex = 5;
            this.btnNewReport.Text = "New Report";
            this.btnNewReport.UseVisualStyleBackColor = false;
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.btnSave.Location = new System.Drawing.Point(267, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.btnEdit.Location = new System.Drawing.Point(458, 541);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 42);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.btnCancel.Location = new System.Drawing.Point(651, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewReport);
            this.Controls.Add(this.lblDescDateEdited);
            this.Controls.Add(this.lblDateEdited);
            this.Controls.Add(this.txtReportContent);
            this.Controls.Add(this.lsbReportDates);
            this.Controls.Add(this.lblProgressReports);
            this.Name = "Dashboard";
            this.Text = "Reports Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgressReports;
        private System.Windows.Forms.ListBox lsbReportDates;
        private System.Windows.Forms.TextBox txtReportContent;
        private System.Windows.Forms.Label lblDateEdited;
        private System.Windows.Forms.Label lblDescDateEdited;
        private System.Windows.Forms.Button btnNewReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}

