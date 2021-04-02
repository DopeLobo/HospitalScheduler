
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
            this.SuspendLayout();
            // 
            // btnEditProviders
            // 
            this.btnEditProviders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditProviders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProviders.Location = new System.Drawing.Point(283, 138);
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
            this.btnMakeSchedule.Location = new System.Drawing.Point(283, 244);
            this.btnMakeSchedule.Name = "btnMakeSchedule";
            this.btnMakeSchedule.Size = new System.Drawing.Size(245, 86);
            this.btnMakeSchedule.TabIndex = 0;
            this.btnMakeSchedule.Text = "Make Schedule";
            this.btnMakeSchedule.UseVisualStyleBackColor = false;
            this.btnMakeSchedule.Click += new System.EventHandler(this.btnMakeSchedule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeSchedule);
            this.Controls.Add(this.btnEditProviders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditProviders;
        private System.Windows.Forms.Button btnMakeSchedule;
    }
}

