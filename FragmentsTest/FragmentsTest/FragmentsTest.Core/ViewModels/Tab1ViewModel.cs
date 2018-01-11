using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace FragmentsTest.Core.ViewModels
{
    public class Tab1ViewModel : MvxViewModel
    {
        string tabNameText = "Tab 1";
        public string TabNameText
        {
            get { return tabNameText; }
            set { SetProperty(ref tabNameText, value); }
        }

        public IMvxCommand ButtonClickedCommand { get; private set; }

        private IMvxNavigationService navService;
        public Tab1ViewModel(IMvxNavigationService navService)
        {
            this.navService = navService;
        }

        public override void Start()
        {
            base.Start();
            ButtonClickedCommand = new MvxCommand(ActionButtonClicked);
        }

        private void ActionButtonClicked()
        {
            this.navService.Navigate<ChildViewModel>();
        }
    }
}
