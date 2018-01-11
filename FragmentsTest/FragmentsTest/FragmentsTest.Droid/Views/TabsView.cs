using System;
using Android.Support.Design.Widget;
using FragmentsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace FragmentsTest.Droid.Views
{
    [MvxFragmentPresentation(ActivityHostViewModelType = typeof(MainViewModel), FragmentContentId = Resource.Id.main_container_frame, AddToBackStack = true)]
    public partial class TabsView : MvxFragment<TabsViewModel>
    {
        public TabsView()
        {
        }

        public override void OnStart()
        {
            base.OnStart();
            BottomNav.SelectedItemId = Resource.Id.menu_home;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.TabsLayout, null);

            //bottomNav.SelectedItemId = Resource.Id.menu_home;

            return view;
        }
    }
}
