package md55c2eb5ee496ca2d1bb797fa4cb5ceb07;


public class ChildView
	extends md5273816ff2327f4ff8d73e35d2c343434.MvxFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("FragmentsTest.Droid.Views.ChildView, FragmentsTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChildView.class, __md_methods);
	}


	public ChildView ()
	{
		super ();
		if (getClass () == ChildView.class)
			mono.android.TypeManager.Activate ("FragmentsTest.Droid.Views.ChildView, FragmentsTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
