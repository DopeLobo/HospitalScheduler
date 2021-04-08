
namespace HospitalScheduler
{
    partial class ImportFilesDialog
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
            this.btnImportProviders = new System.Windows.Forms.Button();
            this.btnImportClinics = new System.Windows.Forms.Button();
            this.labelProviderStatus = new System.Windows.Forms.Label();
            this.labelClinicStatus = new System.Windows.Forms.Label();
            this.btnGenSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportProviders
            // 
            this.btnImportProviders.Location = new System.Drawing.Point(206, 64);
            this.btnImportProviders.Name = "btnImportProviders";
            this.btnImportProviders.Size = new System.Drawing.Size(144, 23);
            this.btnImportProviders.TabIndex = 0;
            this.btnImportProviders.Text = "Import Providers";
            this.btnImportProviders.UseVisualStyleBackColor = true;
            this.btnImportProviders.Click += new System.EventHandler(this.btnImportProviders_Click);
            // 
            // btnImportClinics
            // 
            this.btnImportClinics.Location = new System.Drawing.Point(206, 114);
            this.btnImportClinics.Name = "btnImportClinics";
            this.btnImportClinics.Size = new System.Drawing.Size(144, 23);
            this.btnImportClinics.TabIndex = 1;
            this.btnImportClinics.Text = "Import Clinics";
            this.btnImportClinics.UseVisualStyleBackColor = true;
            this.btnImportClinics.Click += new System.EventHandler(this.btnImportClinics_Click);
            // 
            // labelProviderStatus
            // 
            this.labelProviderStatus.AutoSize = true;
            this.labelProviderStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelProviderStatus.Location = new System.Drawing.Point(397, 73);
            this.labelProviderStatus.Name = "labelProviderStatus";
            this.labelProviderStatus.Size = new System.Drawing.Size(69, 13);
            this.labelProviderStatus.TabIndex = 2;
            this.labelProviderStatus.Text = "Import Status";
            // 
            // labelClinicStatus
            // 
            this.labelClinicStatus.AutoSize = true;
            this.labelClinicStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelClinicStatus.Location = new System.Drawing.Point(397, 119);
            this.labelClinicStatus.Name = "labelClinicStatus";
            this.labelClinicStatus.Size = new System.Drawing.Size(69, 13);
            this.labelClinicStatus.TabIndex = 2;
            this.labelClinicStatus.Text = "Import Status";
            // 
            // btnGenSchedule
            // 
            this.btnGenSchedule.Location = new System.Drawing.Point(301, 204);
            this.btnGenSchedule.Name = "btnGenSchedule";
            this.btnGenSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnGenSchedule.TabIndex = 3;
            this.btnGenSchedule.Text = "Generate Schedule";
            this.btnGenSchedule.UseVisualStyleBackColor = true;
            this.btnGenSchedule.Visible = false;
            this.btnGenSchedule.Click += new System.EventHandler(this.btnGenSchedule_Click);
            // 
            // ImportFilesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenSchedule);
            this.Controls.Add(this.labelClinicStatus);
            this.Controls.Add(this.labelProviderStatus);
            this.Controls.Add(this.btnImportClinics);
            this.Controls.Add(this.btnImportProviders);
            this.Name = "ImportFilesDialog";
            this.Text = "ImportFilesDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportProviders;
        private System.Windows.Forms.Button btnImportClinics;
        private System.Windows.Forms.Label labelProviderStatus;
        private System.Windows.Forms.Label labelClinicStatus;
        private System.Windows.Forms.Button btnGenSchedule;
    }
}