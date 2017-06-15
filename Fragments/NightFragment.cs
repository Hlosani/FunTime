
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace FunTime.Fragments
{
	public class NightFragment : SupportFragment
	{
           private Android.Widget.ListView lv;
		   private String[] night = { "Clubs", "Dinning", "Games", "Gym" };
		   private Android.Widget.ArrayAdapter adapter;

          public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
          {
			View rootView = inflater.Inflate(Resource.Layout.night_layout, container, false);

			lv = rootView.FindViewById<Android.Widget.ListView>(Resource.Id.night_listView);

			adapter = new Android.Widget.ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, night);

	        lv.Adapter = adapter;

			lv.ItemClick += lv_itemClick;

	        return rootView;
           }

		void lv_itemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Toast.MakeText(this.Activity, night[e.Position], ToastLength.Short)
			     .Show();
		}
}
}
