using System;
using FragmentsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace FragmentsTest.Droid.Views
{
    [MvxFragmentPresentation(FragmentHostViewType = typeof(TabsView), FragmentContentId = Resource.Id.tabsContainerFrame, IsCacheableFragment = true)]
    public class Tab3View : MvxFragment<Tab3ViewModel>
    {
        public Tab3View()
        {
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.Tab3Layout, null);

            return view;
        }
    }
}
