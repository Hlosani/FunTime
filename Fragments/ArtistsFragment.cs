
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
		private Android.Widget.ListView lv;
		private String[] artists = { "Cassper Nyovest", "Nasty C", "Emtee", "Lira", "Babes Wodumo", "Tira" };
        private Android.Widget.ArrayAdapter adapter;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View rootView = inflater.Inflate(Resource.Layout.artists_layout, container, false);

			lv = rootView.FindViewById<Android.Widget.ListView>(Resource.Id.artistlistView);

			adapter = new Android.Widget.ArrayAdapter(this.Activity,Android.Resource.Layout.SimpleListItem1, artists);

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

