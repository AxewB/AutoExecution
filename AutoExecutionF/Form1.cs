using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace AutoExecutionF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Profiles profiles = Profiles.get();

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = profilelist_listview.Width / 3;
            profilelist_listview.Items.Clear();
            profilelist_listview.Columns.Add("name", width);
            profilelist_listview.Columns.Add("path", width);
            profilelist_listview.Columns.Add("args", width);

            UpdateProfileList();
        }

        
        public void UpdateProfileList()
        {
            Profiles profiles = Profiles.get();
            List<Profile> profilelist = profiles.getprofilelist();
            combobox_profiles.Items.Clear();
            if (profilelist.Count != 0)
            {
                foreach (Profile item in profilelist)
                {
                    combobox_profiles.Items.Add(item.getname());
                }
            }
            else combobox_profiles.Items.Clear();
            if (profilelist.Count > 0)
            {
                combobox_profiles.SelectedIndex = profilelist.Count-1;
            }
            else profilelist_listview.Items.Clear();
        }
        private void addprofile_button_Click(object sender, EventArgs e)
        {
            AddprofileF addprofile = new AddprofileF(this);
            addprofile.Show();
        }
        private void start_Click(object sender, EventArgs e)
        {
            string prName = combobox_profiles.Text;
            Profile profile = SearchProfile(prName);

            List<App> apps = profile.getapplist();

            for (int i = 0; i < apps.Count; i++)
            {

                var p = new Process();
                p.StartInfo = new ProcessStartInfo(@apps[i].getpath())
                {
                    UseShellExecute = true
                };
                try
                {
                    p.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("OPENING ERROR\n\nFILE NAME >>> " + apps[i].getname() + "\n\nFILE PATH >>> " + apps[i].getpath());                    
                }
                
            }
        }
        public Profile SearchProfile(string s)
        {
            List<Profile> profilelist = profiles.getprofilelist();
            for (int i = 0; i < profilelist.Count; i++)
            {
                Profile profile = profilelist[i];
                if (s == profile.getname())
                {
                    return profile;
                }
            }
            return null;
        }
        private void combobox_profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prName = combobox_profiles.Text;
            Profile profile = SearchProfile(prName);

            List<App> apps = profile.getapplist();

            int width = profilelist_listview.Width /3;
            profilelist_listview.Items.Clear();
            profilelist_listview.Columns.Clear();
            profilelist_listview.Columns.Add("name", width);
            profilelist_listview.Columns.Add("path", width);
            profilelist_listview.Columns.Add("args", width);

            profilelist_listview.Items.Clear();
            foreach (App item in apps)
            {
                ListViewItem lvi = new ListViewItem(item.getname(), item.getpath());

                lvi.SubItems.Add(item.getpath());
                lvi.SubItems.Add(item.getargs());

                profilelist_listview.Items.Add(lvi);
            }
        }
        private void deleteprofile_button_Click(object sender, EventArgs e)
        {
            Profiles profiles = Profiles.get();
            List<Profile> profilelist = profiles.getprofilelist();
            string tempname = "";
            tempname = combobox_profiles.GetItemText(this.combobox_profiles.SelectedItem);

            Profile profile = SearchProfile(tempname);
            profilelist.Remove(profile);

            UpdateProfileList();
            combobox_profiles.Text = "";

            profiles.SaveData();
        }

        private void editprofile_button_Click(object sender, EventArgs e)
        {
            AddprofileF addprofileF = new AddprofileF(this);
            addprofileF.Show();

            Profiles profiles = Profiles.get();
            List<Profile> profilelist = profiles.getprofilelist();
            string tempname = "";
            tempname = combobox_profiles.GetItemText(this.combobox_profiles.SelectedItem);

            Profile profile = SearchProfile(tempname);
        }
    }
}
