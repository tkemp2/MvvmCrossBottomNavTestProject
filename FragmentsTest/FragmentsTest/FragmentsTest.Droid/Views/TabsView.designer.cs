using System;
using Android.Support.Design.Widget;

namespace FragmentsTest.Droid.Views
{
    partial class TabsView
    {
        private BottomNavigationView _bottomNav;

        public BottomNavigationView BottomNav
        {
            get
            {
                if (_bottomNav == null)
                {
                    _bottomNav = this.View.FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
                }
                return _bottomNav;
            }
        }
    }
}
