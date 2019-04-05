namespace FinnysGoogleLauncher
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.googledocs = new System.Windows.Forms.Button();
            this.googlesheets = new System.Windows.Forms.Button();
            this.googleslides = new System.Windows.Forms.Button();
            this.googledrive = new System.Windows.Forms.Button();
            this.googlecalendar = new System.Windows.Forms.Button();
            this.googlegmail = new System.Windows.Forms.Button();
            this.googlekeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // googledocs
            // 
            this.googledocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googledocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googledocs.Location = new System.Drawing.Point(168, 12);
            this.googledocs.Name = "googledocs";
            this.googledocs.Size = new System.Drawing.Size(150, 60);
            this.googledocs.TabIndex = 0;
            this.googledocs.Text = "Docs";
            this.googledocs.UseVisualStyleBackColor = true;
            this.googledocs.Click += new System.EventHandler(this.Googledocs_Click);
            // 
            // googlesheets
            // 
            this.googlesheets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googlesheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlesheets.Location = new System.Drawing.Point(242, 78);
            this.googlesheets.Name = "googlesheets";
            this.googlesheets.Size = new System.Drawing.Size(150, 60);
            this.googlesheets.TabIndex = 1;
            this.googlesheets.Text = "Sheets";
            this.googlesheets.UseVisualStyleBackColor = true;
            this.googlesheets.Click += new System.EventHandler(this.Googlesheets_Click);
            // 
            // googleslides
            // 
            this.googleslides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googleslides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleslides.Location = new System.Drawing.Point(398, 78);
            this.googleslides.Name = "googleslides";
            this.googleslides.Size = new System.Drawing.Size(150, 60);
            this.googleslides.TabIndex = 2;
            this.googleslides.Text = "Slides";
            this.googleslides.UseVisualStyleBackColor = true;
            this.googleslides.Click += new System.EventHandler(this.Googleslides_Click_1);
            // 
            // googledrive
            // 
            this.googledrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googledrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googledrive.Location = new System.Drawing.Point(324, 12);
            this.googledrive.Name = "googledrive";
            this.googledrive.Size = new System.Drawing.Size(150, 60);
            this.googledrive.TabIndex = 3;
            this.googledrive.Text = "Drive";
            this.googledrive.UseVisualStyleBackColor = true;
            this.googledrive.Click += new System.EventHandler(this.Googledrive_Click_1);
            // 
            // googlecalendar
            // 
            this.googlecalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googlecalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlecalendar.Location = new System.Drawing.Point(12, 12);
            this.googlecalendar.Name = "googlecalendar";
            this.googlecalendar.Size = new System.Drawing.Size(150, 60);
            this.googlecalendar.TabIndex = 4;
            this.googlecalendar.Text = "Calendar";
            this.googlecalendar.UseVisualStyleBackColor = true;
            this.googlecalendar.Click += new System.EventHandler(this.Googlecalendar_Click);
            // 
            // googlegmail
            // 
            this.googlegmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googlegmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlegmail.Location = new System.Drawing.Point(480, 12);
            this.googlegmail.Name = "googlegmail";
            this.googlegmail.Size = new System.Drawing.Size(150, 60);
            this.googlegmail.TabIndex = 5;
            this.googlegmail.Text = "Gmail";
            this.googlegmail.UseVisualStyleBackColor = true;
            this.googlegmail.Click += new System.EventHandler(this.Googlegmail_Click);
            // 
            // googlekeep
            // 
            this.googlekeep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googlekeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googlekeep.Location = new System.Drawing.Point(86, 78);
            this.googlekeep.Name = "googlekeep";
            this.googlekeep.Size = new System.Drawing.Size(150, 60);
            this.googlekeep.TabIndex = 6;
            this.googlekeep.Text = "Keep";
            this.googlekeep.UseVisualStyleBackColor = true;
            this.googlekeep.Click += new System.EventHandler(this.Googlekeep_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 151);
            this.Controls.Add(this.googlekeep);
            this.Controls.Add(this.googlegmail);
            this.Controls.Add(this.googlecalendar);
            this.Controls.Add(this.googledrive);
            this.Controls.Add(this.googleslides);
            this.Controls.Add(this.googlesheets);
            this.Controls.Add(this.googledocs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Finnys Google Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button googledocs;
        private System.Windows.Forms.Button googlesheets;
        private System.Windows.Forms.Button googleslides;
        private System.Windows.Forms.Button googledrive;
        private System.Windows.Forms.Button googlecalendar;
        private System.Windows.Forms.Button googlegmail;
        private System.Windows.Forms.Button googlekeep;
    }
}

