using System;
using Android.App;
using FragmentsTest.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FragmentsTest.Droid.Activities
{
    [Activity]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        public MainActivity()
        {
        }

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);

            this.SetContentView(Resource.Layout.MainContainerLayout);
        }

        public override void OnBackPressed()
        {
            if (this.SupportFragmentManager.BackStackEntryCount > 0)
                this.SupportFragmentManager.PopBackStack();
            else
                base.OnBackPressed();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }
    }
}
