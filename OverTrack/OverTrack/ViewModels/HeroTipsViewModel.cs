using OverTrack.Models;
using OverTrack.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace OverTrack.ViewModels
{
    public class HeroTipsViewModel : INotifyPropertyChanged
    {
        public ICommand NavigateCommand { get; set; }

        public ObservableCollection<HeroButton> HeroButtons { get; set; } = new ObservableCollection<HeroButton>();

        public event PropertyChangedEventHandler PropertyChanged;

        public HeroTipsViewModel()
        {
            HeroButtons.Add(new HeroButton { Name = "Ana", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconAna.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Ashe", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconAshe.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Baptiste", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconBaptiste.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Bastion", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconBastion.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Brigitte", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconBrigitte.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Cassidy", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconCassidy.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "DVa", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconDVa.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Doomfist", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconDoomfist.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Echo", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconEcho.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Genji", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconGenji.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Hanzo", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconHanzo.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Junkrat", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconJunkrat.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Lucio", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconLucio.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Mei", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconMei.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Mercy", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconMercy.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Moira", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconMoira.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });
            HeroButtons.Add(new HeroButton { Name = "Orisa", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconOrisa.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Pharah", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconPharah.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Reaper", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconReaper.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Reinhardt", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconReinhardt.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Roadhog", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconRoadhog.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Sigma", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconSigma.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Soldier76", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconSoldier76.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Sombra", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconSombra.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Symmetra", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconSymmetra.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Torbjorn", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconTorbjorn.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Tracer", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconTracer.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Widowmaker", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconWidowmaker.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Damage.png"), Role = "Damage" });
            HeroButtons.Add(new HeroButton { Name = "Winston", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconWinston.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Wrecking Ball", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconWreckingBall.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Zarya", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconZarya.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Tank.png"), Role = "Tank" });
            HeroButtons.Add(new HeroButton { Name = "Zenyatta", Portrait = ImageSource.FromResource("OverTrack.Resources.Images.Portraits.IconZenyatta.png"), RoleIcon = ImageSource.FromResource("OverTrack.Resources.Images.Icons.Support.png"), Role = "Support" });

            NavigateCommand = new Command((Hero) => navigateToPage(Hero));
        }

        private void navigateToPage(object Hero)
        {
            int HeroButtonIndex = HeroButtons.IndexOf(HeroButtons.Where(X => X.Name == Hero.ToString()).FirstOrDefault());
            Application.Current.MainPage.Navigation.PushAsync(new HeroPage(HeroButtons[HeroButtonIndex].Name) { Title = HeroButtons[HeroButtonIndex].Name });
        }
    }
}
