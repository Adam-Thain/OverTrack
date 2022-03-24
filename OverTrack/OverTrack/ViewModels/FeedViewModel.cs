using System.ComponentModel;
using Xamarin.Forms;

namespace OverTrack.ViewModels
{
    public class FeedViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
