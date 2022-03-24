using OverTrack.Models;
using System;
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
            HeroImage = ImageSource.FromResource("OverTrack.Resources.Images.FullViews." + hero + "FullView.png");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "OverTrack.Resources.TextFiles." + hero + "Info.txt";
            var list = new ObservableCollection<string>();
            string line;

            Stream stream = assembly.GetManifestResourceStream(resourceName);
            StreamReader reader = new StreamReader(stream);

            Console.WriteLine(hero + " " + "Selected");

            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }

            HeroName = hero;
            Role = list[0].ToString().ToUpper();
            Health = list[2].ToString();
            Armor = list[3].ToString();
            Shields = list[4].ToString();
            Total = list[5].ToString();

            RoleImage = ImageSource.FromResource("OverTrack.Resources.Images.Icons." + list[0].ToString() + ".png");

            for (var i = 7; i < list.Count; i++)
            {
                Abilities.Add(new Ability { Name = list[i].ToString(), Icon = ImageSource.FromResource("OverTrack.Resources.Images.AbilityIcons." + list[i].ToString() + "Icon.png")});
            }
        }
    }
}
