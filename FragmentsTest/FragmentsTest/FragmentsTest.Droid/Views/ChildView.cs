using System;
using Android.App;
using FragmentsTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views.Attributes;

namespace FragmentsTest.Droid.Views
{
    [MvxFragmentPresentation(ActivityHostViewModelType = typeof(TabsViewModel), FragmentHostViewType = typeof(TabsView), FragmentContentId = Resource.Id.tabsContainerFrame, AddToBackStack = true)]
    public class ChildView : MvxFragment<ChildViewModel>
    {
        public ChildView()
        {
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.ChildFragmentLayout, null);

            return view;
        }
    }
    //[MvxActivityPresentation]
    //[Activity]
    //public class ChildView : MvxAppCompatActivity<ChildViewModel>
    //{
    //    protected override void OnCreate(Android.OS.Bundle bundle)
    //    {
    //        base.OnCreate(bundle);
    //        this.SetContentView(Resource.Layout.ChildFragmentLayout);
    //    }
    //}
}
