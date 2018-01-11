using System;
using MvvmCross.Core.ViewModels;

namespace FragmentsTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
        }

        public override void Start()
        {
            base.Start();
            NavigateToFirstViewModel();
        }

        private void NavigateToFirstViewModel()
        {
            this.ShowViewModel<TabsViewModel>();
        }
    }
}
