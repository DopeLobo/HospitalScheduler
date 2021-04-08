
namespace HospitalScheduler
{
    partial class MakeSchedule
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferencesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferencesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedLeaveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferencesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedLeaveDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.preferencesDataGridViewTextBoxColumn,
            this.approvedLeaveDataGridViewTextBoxColumn,
            this.clinicDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.licenseDataGridViewTextBoxColumn,
            this.scheduleTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(713, 402);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(618, 402);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // preferencesDataGridViewTextBoxColumn
            // 
            this.preferencesDataGridViewTextBoxColumn.DataPropertyName = "Preferences";
            this.preferencesDataGridViewTextBoxColumn.HeaderText = "Preferences";
            this.preferencesDataGridViewTextBoxColumn.Name = "preferencesDataGridViewTextBoxColumn";
            // 
            // approvedLeaveDataGridViewTextBoxColumn
            // 
            this.approvedLeaveDataGridViewTextBoxColumn.DataPropertyName = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn.HeaderText = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn.Name = "approvedLeaveDataGridViewTextBoxColumn";
            // 
            // clinicDataGridViewTextBoxColumn
            // 
            this.clinicDataGridViewTextBoxColumn.DataPropertyName = "Clinic";
            this.clinicDataGridViewTextBoxColumn.HeaderText = "Clinic";
            this.clinicDataGridViewTextBoxColumn.Name = "clinicDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // licenseDataGridViewTextBoxColumn
            // 
            this.licenseDataGridViewTextBoxColumn.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn.Name = "licenseDataGridViewTextBoxColumn";
            // 
            // scheduleTypeDataGridViewTextBoxColumn
            // 
            this.scheduleTypeDataGridViewTextBoxColumn.DataPropertyName = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn.HeaderText = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn.Name = "scheduleTypeDataGridViewTextBoxColumn";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(HospitalScheduler.Schedule);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinicIDDataGridViewTextBoxColumn,
            this.clinicNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn1,
            this.preferencesDataGridViewTextBoxColumn1,
            this.approvedLeaveDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.specialtyDataGridViewTextBoxColumn1,
            this.licenseDataGridViewTextBoxColumn1,
            this.scheduleTypeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.clinicBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 108);
            this.dataGridView2.TabIndex = 4;
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataSource = typeof(HospitalScheduler.Clinic);
            // 
            // clinicIDDataGridViewTextBoxColumn
            // 
            this.clinicIDDataGridViewTextBoxColumn.DataPropertyName = "ClinicID";
            this.clinicIDDataGridViewTextBoxColumn.HeaderText = "ClinicID";
            this.clinicIDDataGridViewTextBoxColumn.Name = "clinicIDDataGridViewTextBoxColumn";
            // 
            // clinicNameDataGridViewTextBoxColumn
            // 
            this.clinicNameDataGridViewTextBoxColumn.DataPropertyName = "ClinicName";
            this.clinicNameDataGridViewTextBoxColumn.HeaderText = "ClinicName";
            this.clinicNameDataGridViewTextBoxColumn.Name = "clinicNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // preferencesDataGridViewTextBoxColumn1
            // 
            this.preferencesDataGridViewTextBoxColumn1.DataPropertyName = "Preferences";
            this.preferencesDataGridViewTextBoxColumn1.HeaderText = "Preferences";
            this.preferencesDataGridViewTextBoxColumn1.Name = "preferencesDataGridViewTextBoxColumn1";
            // 
            // approvedLeaveDataGridViewTextBoxColumn1
            // 
            this.approvedLeaveDataGridViewTextBoxColumn1.DataPropertyName = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn1.HeaderText = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn1.Name = "approvedLeaveDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // specialtyDataGridViewTextBoxColumn1
            // 
            this.specialtyDataGridViewTextBoxColumn1.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn1.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn1.Name = "specialtyDataGridViewTextBoxColumn1";
            // 
            // licenseDataGridViewTextBoxColumn1
            // 
            this.licenseDataGridViewTextBoxColumn1.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn1.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn1.Name = "licenseDataGridViewTextBoxColumn1";
            // 
            // scheduleTypeDataGridViewTextBoxColumn1
            // 
            this.scheduleTypeDataGridViewTextBoxColumn1.DataPropertyName = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn1.HeaderText = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn1.Name = "scheduleTypeDataGridViewTextBoxColumn1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerIDDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn2,
            this.preferencesDataGridViewTextBoxColumn2,
            this.approvedLeaveDataGridViewTextBoxColumn2,
            this.typeDataGridViewTextBoxColumn2,
            this.specialtyDataGridViewTextBoxColumn2,
            this.licenseDataGridViewTextBoxColumn2,
            this.scheduleTypeDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.providerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 285);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(800, 94);
            this.dataGridView3.TabIndex = 5;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(HospitalScheduler.Provider);
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            this.providerIDDataGridViewTextBoxColumn.DataPropertyName = "ProviderID";
            this.providerIDDataGridViewTextBoxColumn.HeaderText = "ProviderID";
            this.providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            this.providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.HeaderText = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn2
            // 
            this.phoneDataGridViewTextBoxColumn2.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn2.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn2.Name = "phoneDataGridViewTextBoxColumn2";
            // 
            // preferencesDataGridViewTextBoxColumn2
            // 
            this.preferencesDataGridViewTextBoxColumn2.DataPropertyName = "Preferences";
            this.preferencesDataGridViewTextBoxColumn2.HeaderText = "Preferences";
            this.preferencesDataGridViewTextBoxColumn2.Name = "preferencesDataGridViewTextBoxColumn2";
            // 
            // approvedLeaveDataGridViewTextBoxColumn2
            // 
            this.approvedLeaveDataGridViewTextBoxColumn2.DataPropertyName = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn2.HeaderText = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn2.Name = "approvedLeaveDataGridViewTextBoxColumn2";
            // 
            // typeDataGridViewTextBoxColumn2
            // 
            this.typeDataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn2.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn2.Name = "typeDataGridViewTextBoxColumn2";
            // 
            // specialtyDataGridViewTextBoxColumn2
            // 
            this.specialtyDataGridViewTextBoxColumn2.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn2.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn2.Name = "specialtyDataGridViewTextBoxColumn2";
            // 
            // licenseDataGridViewTextBoxColumn2
            // 
            this.licenseDataGridViewTextBoxColumn2.DataPropertyName = "License";
            this.licenseDataGridViewTextBoxColumn2.HeaderText = "License";
            this.licenseDataGridViewTextBoxColumn2.Name = "licenseDataGridViewTextBoxColumn2";
            // 
            // scheduleTypeDataGridViewTextBoxColumn2
            // 
            this.scheduleTypeDataGridViewTextBoxColumn2.DataPropertyName = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn2.HeaderText = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn2.Name = "scheduleTypeDataGridViewTextBoxColumn2";
            // 
            // MakeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MakeSchedule";
            this.Text = "MakeSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferencesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferencesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedLeaveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferencesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedLeaveDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource providerBindingSource;
    }
}