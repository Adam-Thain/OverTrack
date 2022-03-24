using OverTrack.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OverTrack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeroPage : ContentPage
    {
        public HeroPage(string Hero)
        {
            InitializeComponent();
            BindingContext = new HeroPageViewModel(Hero);
        }
    }
}