package md53949eadadb7481c85bedb428f645d029;


public abstract class MvxDialogFragment_1
	extends mvvmcross.droid.fragments.MvxDialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Views.Fragments.MvxDialogFragment`1, MvvmCross.Droid, Version=5.6.3.0, Culture=neutral, PublicKeyToken=null", MvxDialogFragment_1.class, __md_methods);
	}


	public MvxDialogFragment_1 ()
	{
		super ();
		if (getClass () == MvxDialogFragment_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Views.Fragments.MvxDialogFragment`1, MvvmCross.Droid, Version=5.6.3.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
