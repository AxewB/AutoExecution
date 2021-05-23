
namespace AutoExecutionF
{
    partial class AddprofileF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddprofileF));
            this.label1 = new System.Windows.Forms.Label();
            this.profilename_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addapp_button = new System.Windows.Forms.Button();
            this.deleteapp_button = new System.Windows.Forms.Button();
            this.appname_textbox = new System.Windows.Forms.TextBox();
            this.apppath_textbox = new System.Windows.Forms.TextBox();
            this.appargs_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apps_listView = new System.Windows.Forms.ListView();
            this.addprofile_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errmsg_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile name";
            // 
            // profilename_textbox
            // 
            this.profilename_textbox.Location = new System.Drawing.Point(96, 12);
            this.profilename_textbox.Name = "profilename_textbox";
            this.profilename_textbox.Size = new System.Drawing.Size(466, 23);
            this.profilename_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "App list";
            // 
            // addapp_button
            // 
            this.addapp_button.Location = new System.Drawing.Point(381, 205);
            this.addapp_button.Name = "addapp_button";
            this.addapp_button.Size = new System.Drawing.Size(75, 23);
            this.addapp_button.TabIndex = 4;
            this.addapp_button.Text = "add";
            this.addapp_button.UseVisualStyleBackColor = true;
            this.addapp_button.Click += new System.EventHandler(this.addapp_button_Click);
            // 
            // deleteapp_button
            // 
            this.deleteapp_button.Location = new System.Drawing.Point(462, 205);
            this.deleteapp_button.Name = "deleteapp_button";
            this.deleteapp_button.Size = new System.Drawing.Size(75, 23);
            this.deleteapp_button.TabIndex = 5;
            this.deleteapp_button.Text = "delete";
            this.deleteapp_button.UseVisualStyleBackColor = true;
            this.deleteapp_button.Click += new System.EventHandler(this.deleteapp_button_Click);
            // 
            // appname_textbox
            // 
            this.appname_textbox.Location = new System.Drawing.Point(406, 115);
            this.appname_textbox.Name = "appname_textbox";
            this.appname_textbox.Size = new System.Drawing.Size(156, 23);
            this.appname_textbox.TabIndex = 6;
            // 
            // apppath_textbox
            // 
            this.apppath_textbox.Location = new System.Drawing.Point(406, 144);
            this.apppath_textbox.Name = "apppath_textbox";
            this.apppath_textbox.Size = new System.Drawing.Size(120, 23);
            this.apppath_textbox.TabIndex = 7;
            // 
            // appargs_textbox
            // 
            this.appargs_textbox.Location = new System.Drawing.Point(406, 176);
            this.appargs_textbox.Name = "appargs_textbox";
            this.appargs_textbox.Size = new System.Drawing.Size(156, 23);
            this.appargs_textbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "args";
            // 
            // apps_listView
            // 
            this.apps_listView.HideSelection = false;
            this.apps_listView.Location = new System.Drawing.Point(13, 76);
            this.apps_listView.Name = "apps_listView";
            this.apps_listView.Size = new System.Drawing.Size(318, 188);
            this.apps_listView.TabIndex = 12;
            this.apps_listView.UseCompatibleStateImageBehavior = false;
            this.apps_listView.View = System.Windows.Forms.View.Details;
            // 
            // addprofile_button
            // 
            this.addprofile_button.Location = new System.Drawing.Point(273, 289);
            this.addprofile_button.Name = "addprofile_button";
            this.addprofile_button.Size = new System.Drawing.Size(75, 23);
            this.addprofile_button.TabIndex = 13;
            this.addprofile_button.Text = "finish";
            this.addprofile_button.UseVisualStyleBackColor = true;
            this.addprofile_button.Click += new System.EventHandler(this.addprofile_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(532, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errmsg_label
            // 
            this.errmsg_label.AutoSize = true;
            this.errmsg_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errmsg_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errmsg_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errmsg_label.Location = new System.Drawing.Point(418, 249);
            this.errmsg_label.Name = "errmsg_label";
            this.errmsg_label.Size = new System.Drawing.Size(40, 15);
            this.errmsg_label.TabIndex = 15;
            this.errmsg_label.Text = "label6";
            // 
            // AddprofileF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 324);
            this.Controls.Add(this.errmsg_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addprofile_button);
            this.Controls.Add(this.apps_listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appargs_textbox);
            this.Controls.Add(this.apppath_textbox);
            this.Controls.Add(this.appname_textbox);
            this.Controls.Add(this.deleteapp_button);
            this.Controls.Add(this.addapp_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profilename_textbox);
            this.Controls.Add(this.label1);
            this.Name = "AddprofileF";
            this.Text = "addprofile";
            this.Load += new System.EventHandler(this.AddprofileF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profilename_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addapp_button;
        private System.Windows.Forms.Button deleteapp_button;
        private System.Windows.Forms.TextBox appname_textbox;
        private System.Windows.Forms.TextBox apppath_textbox;
        private System.Windows.Forms.TextBox appargs_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView apps_listView;
        private System.Windows.Forms.Button addprofile_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errmsg_label;
    }
}