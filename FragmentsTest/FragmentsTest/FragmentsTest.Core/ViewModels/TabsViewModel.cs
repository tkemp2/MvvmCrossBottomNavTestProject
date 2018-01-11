using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace FragmentsTest.Core.ViewModels
{
    public class TabsViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;
        public TabsViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public IMvxCommand<string> BottomNavigationItemSelectedCommand
        {
            get;
            private set;
        }

        public override void Start()
        {
            base.Start();
            BottomNavigationItemSelectedCommand = new MvxCommand<string>(BottomNavigationItemSelected);
        }

        private void BottomNavigationItemSelected(string vmName)
        {
            switch (vmName)
            {
                case "Setup":
                    {
                        this.navigationService.Navigate<Tab3ViewModel>();
                        break;
                    }
                case "Home":
                    {
                        this.navigationService.Navigate<Tab1ViewModel>();
                        break;
                    }
                case "Information":
                    {
                        this.navigationService.Navigate<Tab2ViewModel>();
                        break;
                    }
            }

        }
    }
}
