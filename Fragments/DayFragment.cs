﻿
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
	public class DayFragment : SupportFragment
	{
		 private Android.Widget.ListView lv;
         private String[] day = {"Picnics", "Movies", "Games", "Gym" };
		 private Android.Widget.ArrayAdapter adapter;

		public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container,Bundle savedInstanceState)
		{
			View rootView = inflater.Inflate(Resource.Layout.day_layout, container, false);

			lv = rootView.FindViewById<Android.Widget.ListView>(Resource.Id.daylistView);

			adapter = new Android.Widget.ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, day);

			lv.Adapter = adapter;

			lv.ItemClick += lv_itemClick;

			return rootView;
		}

		void lv_itemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Toast.MakeText(this.Activity, day[e.Position], ToastLength.Short)
			     .Show();
		}
}
}
