
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Lang;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FunTime
{
	public class FunTimeAdapter : Android.Support.V4.App.FragmentPagerAdapter
	{
		Android.Support.V4.App.Fragment[] fragments;
		ICharSequence[] titles;

		public FunTimeAdapter(
			Android.Support.V4.App.FragmentManager fm, 
			Android.Support.V4.App.Fragment[] fragments, 
			ICharSequence[] titles)
			: base(fm)
		{
			this.fragments = fragments;
			this.titles = titles;
		}

		public override int Count
	    {
			get 
			{
				return fragments.Length;
			}
		
		}

		public override Android.Support.V4.App.Fragment GetItem(int position)
		{
			return fragments[position];
		}

	    public override ICharSequence GetPageTitleFormatted(int position) 
		{
			return titles[position];
		}
	}
}
