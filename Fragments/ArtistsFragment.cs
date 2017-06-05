
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace FunTime.Fragments
{
	public class ArtistsFragment : SupportFragment
    {
	      private ListView lv;
	      private String[] artists = { "Cassper Nyovest", "Nasty_C", "Tira", "Lira" };
	      private ArrayAdapter adapter;

	      public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
	      {
		       View rootView = inflater.Inflate(Resource.Layout.day_layout, container, false);

			   lv = rootView.FindViewById<ListView>(Resource.Id.artistlistView);

			adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, artists);

		       lv.Adapter = adapter;
			 
		       lv.ItemClick += lv_itemClick;

		       return rootView;
	      }

	      void lv_itemClick(object sender, AdapterView.ItemClickEventArgs e)
	      {
			Toast.MakeText(this.Activity, artists[e.Position], ToastLength.Short)
			        .Show();
	      }
     }
}

