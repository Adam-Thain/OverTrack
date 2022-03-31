using OverTrack.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace OverTrack.ViewModels
{
    public class HeroPageViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public ObservableCollection<Ability> Abilities { get; set; } = new ObservableCollection<Ability>();
        public ImageSource HeroImage { get; set; }
        public ImageSource RoleImage { get; set; }
        public ImageSource AbilityImage { get; set; }
        public string HeroName { get; set; }
        public string Role { get; set; }
        public string Health { get; set; }
        public string Armor { get; set; }
        public string Shields { get; set; }
        public string Total { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public HeroPageViewModel(string hero)
        {
            LoadAbilities(hero);
        }

        public void LoadAbilities(string hero)
        {
            HeroName = hero;
            HeroImage = ImageSource.FromResource("OverTrack.Resources.Images.FullViews." + hero + "FullView.png");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "OverTrack.Resources.TextFiles." + hero + "Info.txt";
            var list = new ObservableCollection<string>();
            var headerStrings = new ObservableCollection<string>();
            var contentStrings = new ObservableCollection<string>();
            var descriptionStrings = new ObservableCollection<string>();
            string line;

            Stream stream = assembly.GetManifestResourceStream(resourceName);
            StreamReader reader = new StreamReader(stream);;

            using (reader = new StreamReader(stream, System.Text.Encoding.UTF8))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] strArray;
                    strArray = line.Split('|');
                    list.Add(line);

                    if (strArray.Length > 0)
                    {
                        headerStrings.Add(strArray[0]);
                    }

                    if (strArray.Length > 1)
                    {
                        contentStrings.Add(strArray[1]);
                    }

                    if (strArray.Length > 2)
                    {
                        descriptionStrings.Add(strArray[2]);
                    }
                    else
                    {
                        descriptionStrings.Add("");
                    }
                }
            }

            if (contentStrings.Count > 0)
            {
                Role = contentStrings[0].ToUpper();
                RoleImage = ImageSource.FromResource("OverTrack.Resources.Images.Icons." + contentStrings[0] + ".png");
                Health = contentStrings[1];
                Armor = contentStrings[2];
                Shields = contentStrings[3];
                Total = contentStrings[4];

                for (var i = 5; i < list.Count; i++)
                {
                    Abilities.Add(new Ability { Name = headerStrings[i], Icon = ImageSource.FromResource("OverTrack.Resources.Images.AbilityIcons." + contentStrings[i] + "Icon.png"), Description = descriptionStrings[i] });
                }
            }
        }
    }
}
