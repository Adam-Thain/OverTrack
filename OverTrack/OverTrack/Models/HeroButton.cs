using System.Windows.Input;
using Xamarin.Forms;

namespace OverTrack.Models
{
    public class HeroButton
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public ImageSource Portrait { get; set; }
        public ImageSource RoleIcon { get; set; }
        public ICommand NavigateCommand { get; set; }
    }
}
