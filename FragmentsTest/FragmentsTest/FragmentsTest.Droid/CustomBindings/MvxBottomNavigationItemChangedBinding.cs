using System;
using Android.Support.Design.Widget;
using MvvmCross.Binding.Droid.Target;
using MvvmCross.Core.ViewModels;

namespace FragmentsTest.Droid
{
    public class MvxBottomNavigationItemChangedBinding : MvxAndroidTargetBinding
    {
        private readonly BottomNavigationView _bottomNav;
        private IMvxCommand _command;

        public MvxBottomNavigationItemChangedBinding(BottomNavigationView bottomNav) : base(bottomNav)
        {
            _bottomNav = bottomNav;
            _bottomNav.NavigationItemSelected += _bottomNav_NavigationItemSelected;
        }

        void _bottomNav_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            if (_command != null)
                _command.Execute(e.Item.TitleFormatted.ToString());
        }

        public override void SetValue(object value)
        {
            _command = (IMvxCommand)value;
        }

        protected override void Dispose(bool isDisposing)
        {
            if(isDisposing)
            {
                _bottomNav.NavigationItemSelected -= _bottomNav_NavigationItemSelected;
            }
            base.Dispose(isDisposing);
        }

        public override Type TargetType => typeof(MvxCommand);

        protected override void SetValueImpl(object target, object value)
        {
            
        }

        public override MvvmCross.Binding.MvxBindingMode DefaultMode
        {
            get
            {
                return MvvmCross.Binding.MvxBindingMode.TwoWay;
            }
        }
    }
}
