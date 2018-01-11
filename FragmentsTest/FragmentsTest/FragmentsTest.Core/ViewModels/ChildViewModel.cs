using System;
using MvvmCross.Core.ViewModels;

namespace FragmentsTest.Core.ViewModels
{
    public class ChildViewModel : MvxViewModel
    {
        string bodyText = "This is a child Fragment";
        public string BodyText
        {
            get { return bodyText; }
            set { SetProperty(ref bodyText, value); }
        }
        public ChildViewModel()
        {
        }
    }
}
