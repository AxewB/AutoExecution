using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace AutoExecutionF
{
    public class Profiles
    {        
        List<Profile> profiles = new List<Profile>();
        public static Profiles sProfiles;

        public void addprofile(Profile profile)
        {
            profiles.Add(profile);
        }
        public List<Profile> getprofilelist()
        {
            return profiles;
        }

        public static Profiles get()
        {
            if (sProfiles == null)
            {
                sProfiles = new Profiles();
                sProfiles.LoadData();
            }
            return sProfiles;
        }

        public void SaveData()
        {
            Profiles profiles = Profiles.get();
            List<Profile> profilelist = profiles.getprofilelist();
            using (StreamWriter sw = new StreamWriter("saveddata.txt", false, System.Text.Encoding.Default))
            {
                foreach (Profile p in profilelist)
                {
                    List<App> apps = p.getapplist();
                    sw.WriteLine("<PROFILENAME>\n" + p.getname());
                    foreach (App a in apps)
                    {
                        sw.WriteLine("<APP>\n" + a.getname() + '\n' + a.getpath() + '\n' + a.getargs());
                    }
                    sw.WriteLine('\n');
                }
            }
        }
        public void LoadData()
        {
            Profiles profiles = Profiles.get();
            List<Profile> profilelist = profiles.getprofilelist();
            if (!File.Exists("saveddata.txt")) return;
            using (StreamReader sr = new StreamReader("saveddata.txt", System.Text.Encoding.Default))
            {               
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    if (line == "<PROFILENAME>")
                    {
                        Profile p = new Profile();
                        line = sr.ReadLine();
                        p.setname(line);
                        profilelist.Add(p);

                        line = sr.ReadLine();
                        while (line == "<APP>")
                        {
                            App a = new App();
                            line = sr.ReadLine();
                            a.setname(line);
                            line = sr.ReadLine();
                            a.setpath(line);
                            line = sr.ReadLine();
                            a.setargs(line);
                            p.addapp(a);
                            line = sr.ReadLine();
                        }
                    }
                }
            }
        }
    }
    
    public class Profile
    {
        string name;
        List<App> apps = new List<App>();

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public void addapp(App app)
        {
            apps.Add(app);
        }
        public void addapps(List<App> apps)
        {
            this.apps = apps;
        }
        public List<App> getapplist()
        {
            return apps;
        }
    }
    public class App
    {
        string name;
        string path;
        string args;

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public void setpath(string path)
        {
            this.path = path;
        }
        public string getpath()
        {
            return path;
        }
        public void setargs(string args)
        {
            this.args = args;
        }
        public string getargs()
        {
            return args;
        }
    }
}
