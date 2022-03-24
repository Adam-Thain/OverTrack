using System.ComponentModel;
using Xamarin.Forms;

namespace OverTrack.ViewModels
{
    public class AccountViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
