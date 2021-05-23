using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace AutoExecutionF
{
    public partial class AddprofileF : Form
    {
        Form1 form;
        bool edit = false;
        public AddprofileF(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            profile = new Profile();
            apps = new List<App>();
        }
        
        
        public AddprofileF(Form1 form, Profile p)
        {
            InitializeComponent();
            this.form = form;
            profile = p;
            apps = profile.getapplist();
            edit = true;
            profilename_textbox.Text = profile.getname();

        }

        private void AddprofileF_Load(object sender, EventArgs e)
        {
            int width = apps_listView.Width / 3;
            apps_listView.Items.Clear();
            apps_listView.Columns.Add("name", width);
            apps_listView.Columns.Add("path", width);
            apps_listView.Columns.Add("args", width);
            UpdateList();

            errmsg_label.Visible = false;
        }
        Profile profile;
        List<App> apps;       
        private void addapp_button_Click(object sender, EventArgs e)
        {
            App app = new App();            

            string name;
            string path;
            string args;

            name = appname_textbox.Text;
            if (name.Length < 1)
            {
                errormsg("FILE NAME");
                return;
            }
            else errmsg_label.Hide();
            path = apppath_textbox.Text;
            if (path.Length < 1)
            {
                errormsg("FILE PATH");
                return;
            }
            else errmsg_label.Hide();
            args = appargs_textbox.Text;

            app.setname(name);
            app.setpath(path);
            app.setargs(args);

            apps.Add(app);

            UpdateList();
        }
        public void UpdateList()
        {
            apps_listView.Items.Clear();
            foreach (App item in apps)
            {
                ListViewItem lvi = new ListViewItem(item.getname(), item.getpath());

                lvi.SubItems.Add(item.getpath());
                lvi.SubItems.Add(item.getargs());

                apps_listView.Items.Add(lvi);
            }
        }
        public void errormsg(string errorname)
        {
            errmsg_label.Visible = true;
            errmsg_label.Text = "MISSING: " + errorname;

            Thread thread = new Thread(AddprofileF.PrintError);
            thread.Start(errmsg_label);
        }
        public static void PrintError(object data)
        {
            Label label = (Label)data;
            label.ForeColor = Color.FromArgb(255, 255, 0, 0);

            for (int i = 2; i > 0; i--)
            {
                for (int j = 2; j < 255; j+=10)
                {
                    label.ForeColor = Color.FromArgb(255, 255-j, 0, 0);
                    Thread.Sleep(1);
                }
                Thread.Sleep(100);
                for (int k = 2; k < 255; k+=10)
                {
                    label.ForeColor = Color.FromArgb(255, k, 0, 0);
                    Thread.Sleep(1);
                }
                Thread.Sleep(100);
            }
            label.Invoke(new EventHandler(delegate { label.Visible = false; }));
        }
        public App searchByName(string s)
        {
            for (int i = 0; i < apps.Count; i++)
            {
                App app = apps[i];
                if (s == app.getname())
                {
                    return app;
                }
            }
            return null;
        }
        private void deleteapp_button_Click(object sender, EventArgs e)
        {
            string tempname = "";
            for (int i = 0; i < apps_listView.SelectedItems.Count; i++)
            {
                tempname = apps_listView.SelectedItems[i].Text;
            }
            
            App app = searchByName(tempname);        
            apps.Remove(app);

            UpdateList();
        }
        Profiles profiles = Profiles.get();
        private void addprofile_button_Click(object sender, EventArgs e)
        {
            string name;
            name = profilename_textbox.Text;
            if (name.Length < 1)
            {
                errormsg("PROFILE NAME");
                return;
            }
            else errmsg_label.Hide();
            profile.setname(name);
            profile.addapps(apps);
            if (!edit)
            {
                profiles.addprofile(profile);
            }
            

            profiles.SaveData();
            form.UpdateProfileList();
            Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string name = "";
            string path = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                name = ofd.SafeFileName;
                path = ofd.FileName;
            }


            appname_textbox.Text = name;
            apppath_textbox.Text = path;

        }

    }
}
