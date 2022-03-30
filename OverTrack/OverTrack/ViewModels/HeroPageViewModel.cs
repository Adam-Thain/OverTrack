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
        public string AbilityName { get; set; }
        public string AbilityIcon { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public HeroPageViewModel(string hero)
        {
            LoadAbilities(hero);
        }

        public void LoadAbilities(string hero)
        {
            HeroImage = ImageSource.FromResource("OverTrack.Resources.Images.FullViews." + hero + "FullView.png");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "OverTrack.Resources.TextFiles." + hero + "Info.txt";
            var list = new ObservableCollection<string>();
            var headerstrings = new ObservableCollection<string>();
            var contentstrings = new ObservableCollection<string>();
            string line;

            Stream stream = assembly.GetManifestResourceStream(resourceName);
            StreamReader reader = new StreamReader(stream);;

            using (reader = new StreamReader(stream))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] strArray;
                    strArray = line.Split(',');
                    list.Add(line);

                    if (strArray.Length > 0)
                    {
                        headerstrings.Add(strArray[0]);
                    }

                    if (strArray.Length > 1)
                    {
                        contentstrings.Add(strArray[1]);
                    }
                }
            }

            if (contentstrings.Count > 0)
            {
                Role = contentstrings[0].ToUpper();
                RoleImage = ImageSource.FromResource("OverTrack.Resources.Images.Icons." + contentstrings[0] + ".png");
                Health = contentstrings[1];
                Armor = contentstrings[2];
                Shields = contentstrings[3];
                Total = contentstrings[4];

                for (var i = 5; i < list.Count; i++)
                {
                    Abilities.Add(new Ability { Name = headerstrings[i], Icon = ImageSource.FromResource("OverTrack.Resources.Images.AbilityIcons." + contentstrings[i] + "Icon.png") });
                }
            }
        }
    }
}
