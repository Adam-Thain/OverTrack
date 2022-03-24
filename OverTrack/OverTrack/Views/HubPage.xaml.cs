using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OverTrack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HubPage : TabbedPage
    {
        bool DamageSelected = false;
        bool DefenceSelected = false;
        bool TankSelected = false;
        bool SupportSelected = false;

        public HubPage()
        {
            InitializeComponent();
        }

        private void DamageButtonTapped(object sender, EventArgs e)
        {
            if (!DamageSelected)
            {
                DamageButton.Opacity = 0.5;
                DamageSelected = true;
            }
            else
            {
                DamageButton.Opacity = 1.0;
                DamageSelected = false;
            }
        }

        private void DefenceButtonTapped(object sender, EventArgs e)
        {
            if (!DefenceSelected)
            {
                DefenceButton.Opacity = 0.5;
                DefenceSelected = true;
            }
            else
            {
                DefenceButton.Opacity = 1.0;
                DefenceSelected = false;
            }
        }

        private void TankButtonTapped(object sender, EventArgs e)
        {
            if (!TankSelected)
            {
                TankButton.Opacity = 0.5;
                TankSelected = true;
            }
            else
            {
                TankButton.Opacity = 1.0;
                TankSelected = false;
            }

        }

        private void SupportButtonTapped(object sender, EventArgs e)
        {
            if (!SupportSelected)
            {
                SupportButton.Opacity = 0.5;
                SupportSelected = true;
            }
            else
            {
                SupportButton.Opacity = 1.0;
                SupportSelected = false; 
            }
        }
    }
}