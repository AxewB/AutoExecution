
namespace AutoExecutionF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.addprofile_button = new System.Windows.Forms.Button();
            this.deleteprofile_button = new System.Windows.Forms.Button();
            this.editprofile_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profilelist_listview = new System.Windows.Forms.ListView();
            this.combobox_profiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(494, 190);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 62);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // addprofile_button
            // 
            this.addprofile_button.Location = new System.Drawing.Point(494, 67);
            this.addprofile_button.Name = "addprofile_button";
            this.addprofile_button.Size = new System.Drawing.Size(75, 23);
            this.addprofile_button.TabIndex = 1;
            this.addprofile_button.Text = "add";
            this.addprofile_button.UseVisualStyleBackColor = true;
            this.addprofile_button.Click += new System.EventHandler(this.addprofile_button_Click);
            // 
            // deleteprofile_button
            // 
            this.deleteprofile_button.Location = new System.Drawing.Point(494, 125);
            this.deleteprofile_button.Name = "deleteprofile_button";
            this.deleteprofile_button.Size = new System.Drawing.Size(75, 23);
            this.deleteprofile_button.TabIndex = 2;
            this.deleteprofile_button.Text = "delete";
            this.deleteprofile_button.UseVisualStyleBackColor = true;
            this.deleteprofile_button.Click += new System.EventHandler(this.deleteprofile_button_Click);
            // 
            // editprofile_button
            // 
            this.editprofile_button.Location = new System.Drawing.Point(494, 96);
            this.editprofile_button.Name = "editprofile_button";
            this.editprofile_button.Size = new System.Drawing.Size(75, 23);
            this.editprofile_button.TabIndex = 3;
            this.editprofile_button.Text = "edit";
            this.editprofile_button.UseVisualStyleBackColor = true;
            this.editprofile_button.Click += new System.EventHandler(this.editprofile_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "AUTO EXEC";
            // 
            // profilelist_listview
            // 
            this.profilelist_listview.HideSelection = false;
            this.profilelist_listview.Location = new System.Drawing.Point(12, 67);
            this.profilelist_listview.Name = "profilelist_listview";
            this.profilelist_listview.Size = new System.Drawing.Size(476, 185);
            this.profilelist_listview.TabIndex = 6;
            this.profilelist_listview.UseCompatibleStateImageBehavior = false;
            this.profilelist_listview.View = System.Windows.Forms.View.Details;
            // 
            // combobox_profiles
            // 
            this.combobox_profiles.FormattingEnabled = true;
            this.combobox_profiles.Location = new System.Drawing.Point(315, 38);
            this.combobox_profiles.Name = "combobox_profiles";
            this.combobox_profiles.Size = new System.Drawing.Size(173, 23);
            this.combobox_profiles.TabIndex = 7;
            this.combobox_profiles.SelectedIndexChanged += new System.EventHandler(this.combobox_profiles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Profile";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_profiles);
            this.Controls.Add(this.profilelist_listview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editprofile_button);
            this.Controls.Add(this.deleteprofile_button);
            this.Controls.Add(this.addprofile_button);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button addprofile_button;
        private System.Windows.Forms.Button deleteprofile_button;
        private System.Windows.Forms.Button editprofile_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView profilelist_listview;
        private System.Windows.Forms.ComboBox combobox_profiles;
        private System.Windows.Forms.Label label2;
    }
}

