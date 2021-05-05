
namespace HospitalScheduler
{
    partial class EditProviders
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.friDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.satDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.approvedLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerIDDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn,
            this.monDataGridViewTextBoxColumn,
            this.tueDataGridViewTextBoxColumn,
            this.wedDataGridViewTextBoxColumn,
            this.thuDataGridViewTextBoxColumn,
            this.friDataGridViewTextBoxColumn,
            this.satDataGridViewTextBoxColumn,
            this.sunDataGridViewTextBoxColumn,
            this.approvedLeaveDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.scheduleTypeDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridView1.DataSource = this.providerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(589, 363);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 26);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Save";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(684, 363);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 26);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Import";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
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
            // monDataGridViewTextBoxColumn
            // 
            this.monDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.monDataGridViewTextBoxColumn.DataPropertyName = "Mon";
            this.monDataGridViewTextBoxColumn.HeaderText = "M";
            this.monDataGridViewTextBoxColumn.Name = "monDataGridViewTextBoxColumn";
            this.monDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.monDataGridViewTextBoxColumn.Width = 41;
            // 
            // tueDataGridViewTextBoxColumn
            // 
            this.tueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tueDataGridViewTextBoxColumn.DataPropertyName = "Tue";
            this.tueDataGridViewTextBoxColumn.HeaderText = "T";
            this.tueDataGridViewTextBoxColumn.Name = "tueDataGridViewTextBoxColumn";
            this.tueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tueDataGridViewTextBoxColumn.Width = 39;
            // 
            // wedDataGridViewTextBoxColumn
            // 
            this.wedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.wedDataGridViewTextBoxColumn.DataPropertyName = "Wed";
            this.wedDataGridViewTextBoxColumn.HeaderText = "W";
            this.wedDataGridViewTextBoxColumn.Name = "wedDataGridViewTextBoxColumn";
            this.wedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wedDataGridViewTextBoxColumn.Width = 43;
            // 
            // thuDataGridViewTextBoxColumn
            // 
            this.thuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.thuDataGridViewTextBoxColumn.DataPropertyName = "Thu";
            this.thuDataGridViewTextBoxColumn.HeaderText = "Th";
            this.thuDataGridViewTextBoxColumn.Name = "thuDataGridViewTextBoxColumn";
            this.thuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thuDataGridViewTextBoxColumn.Width = 45;
            // 
            // friDataGridViewTextBoxColumn
            // 
            this.friDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.friDataGridViewTextBoxColumn.DataPropertyName = "Fri";
            this.friDataGridViewTextBoxColumn.HeaderText = "F";
            this.friDataGridViewTextBoxColumn.Name = "friDataGridViewTextBoxColumn";
            this.friDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.friDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.friDataGridViewTextBoxColumn.Width = 38;
            // 
            // satDataGridViewTextBoxColumn
            // 
            this.satDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.satDataGridViewTextBoxColumn.DataPropertyName = "Sat";
            this.satDataGridViewTextBoxColumn.HeaderText = "Sat";
            this.satDataGridViewTextBoxColumn.Name = "satDataGridViewTextBoxColumn";
            this.satDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.satDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.satDataGridViewTextBoxColumn.Width = 48;
            // 
            // sunDataGridViewTextBoxColumn
            // 
            this.sunDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sunDataGridViewTextBoxColumn.DataPropertyName = "Sun";
            this.sunDataGridViewTextBoxColumn.HeaderText = "Sun";
            this.sunDataGridViewTextBoxColumn.Name = "sunDataGridViewTextBoxColumn";
            this.sunDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sunDataGridViewTextBoxColumn.Width = 51;
            // 
            // approvedLeaveDataGridViewTextBoxColumn
            // 
            this.approvedLeaveDataGridViewTextBoxColumn.DataPropertyName = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn.HeaderText = "ApprovedLeave";
            this.approvedLeaveDataGridViewTextBoxColumn.Name = "approvedLeaveDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // scheduleTypeDataGridViewTextBoxColumn
            // 
            this.scheduleTypeDataGridViewTextBoxColumn.DataPropertyName = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn.HeaderText = "ScheduleType";
            this.scheduleTypeDataGridViewTextBoxColumn.Name = "scheduleTypeDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 91.29247F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // EditProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditProviders";
            this.Text = "EditProviders";
            this.Load += new System.EventHandler(this.EditProviders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn monDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn friDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn satDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}