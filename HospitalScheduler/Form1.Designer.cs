
namespace HospitalScheduler
{
    partial class Form1
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
            this.btnEditProviders = new System.Windows.Forms.Button();
            this.btnMakeSchedule = new System.Windows.Forms.Button();
            this.btnEditClinics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditProviders
            // 
            this.btnEditProviders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditProviders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProviders.Location = new System.Drawing.Point(283, 130);
            this.btnEditProviders.Name = "btnEditProviders";
            this.btnEditProviders.Size = new System.Drawing.Size(245, 86);
            this.btnEditProviders.TabIndex = 0;
            this.btnEditProviders.Text = "Edit Providers";
            this.btnEditProviders.UseVisualStyleBackColor = false;
            this.btnEditProviders.Click += new System.EventHandler(this.btnEditProviders_Click);
            // 
            // btnMakeSchedule
            // 
            this.btnMakeSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMakeSchedule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeSchedule.Location = new System.Drawing.Point(283, 341);
            this.btnMakeSchedule.Name = "btnMakeSchedule";
            this.btnMakeSchedule.Size = new System.Drawing.Size(245, 86);
            this.btnMakeSchedule.TabIndex = 0;
            this.btnMakeSchedule.Text = "Make Schedule";
            this.btnMakeSchedule.UseVisualStyleBackColor = false;
            this.btnMakeSchedule.Click += new System.EventHandler(this.btnMakeSchedule_Click);
            // 
            // btnEditClinics
            // 
            this.btnEditClinics.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditClinics.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClinics.Location = new System.Drawing.Point(283, 236);
            this.btnEditClinics.Name = "btnEditClinics";
            this.btnEditClinics.Size = new System.Drawing.Size(245, 86);
            this.btnEditClinics.TabIndex = 1;
            this.btnEditClinics.Text = "Edit Clinics";
            this.btnEditClinics.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Scheduler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditClinics);
            this.Controls.Add(this.btnMakeSchedule);
            this.Controls.Add(this.btnEditProviders);
            this.Name = "Form1";
            this.Text = "Quick Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProviders;
        private System.Windows.Forms.Button btnMakeSchedule;
        private System.Windows.Forms.Button btnEditClinics;
        private System.Windows.Forms.Label label1;
    }
}

