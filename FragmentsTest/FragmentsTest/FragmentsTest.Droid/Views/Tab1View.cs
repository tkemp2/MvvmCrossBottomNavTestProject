using System;
using FragmentsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace FragmentsTest.Droid.Views
{
    [MvxFragmentPresentation(FragmentHostViewType = typeof(TabsView), FragmentContentId = Resource.Id.tabsContainerFrame, AddToBackStack = true)]
    public class Tab1View : MvxFragment<Tab1ViewModel>
    {
        public Tab1View()
        {
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.Tab1Layout, null);

            return view;
        }
    }
}
