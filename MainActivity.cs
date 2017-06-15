
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using System.Threading;
using System.Threading.Tasks;
using Android.Views;
using Android.Widget;
using Android.Support.V4.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;
using SupportActionBar = Android.Support.V7.App.ActionBar;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Java.Lang;
using FunTime.Fragments;

namespace FunTime
{
	[Activity(Label = "FunTime", Theme = "@style/MyTheme.Base")]
	public class MainActivity : AppCompatActivity
	{
		private DrawerLayout mDrawerLayout;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.main_layout);

			SupportToolbar toolBar = FindViewById<SupportToolbar>(Resource.Id.toolBar);
			SetSupportActionBar(toolBar);

			SupportActionBar ab = SupportActionBar;
			ab.SetHomeAsUpIndicator(Resource.Drawable.ic_dehaze);
			ab.SetDisplayHomeAsUpEnabled(true);

			mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

			NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
			if (navigationView != null)
			{
				SetUpDrawerContent(navigationView);
			}

			TabLayout tabs = FindViewById<TabLayout>(Resource.Id.tabs);

			ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);

			SetUpViewPager(viewPager);

			tabs.SetupWithViewPager(viewPager);

			FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);

			fab.Click += (o, e) =>
			{
				View anchor = o as View;

				Snackbar.Make(anchor, "Hlosani's First App", Snackbar.LengthLong)
						.SetAction("What's HOT", v =>
				        {
					     //intent
				        })
					   .Show();
			};
				
		}

		private void SetUpViewPager(ViewPager viewPager)
		{
			TabAdapter adapter = new TabAdapter(SupportFragmentManager);
			adapter.AddFragment(new DayFragment(), "Day");
			adapter.AddFragment(new NightFragment(), "Night");
			adapter.AddFragment(new ArtistsFragment(), "Artists");

			viewPager.Adapter = adapter;
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
				case Android.Resource.Id.Home:
					mDrawerLayout.OpenDrawer((int)GravityFlags.Left);
					return true;

				default:
					return base.OnOptionsItemSelected(item);
			}
		}

		private void SetUpDrawerContent(NavigationView navigationView)
		{
			navigationView.NavigationItemSelected += (object sender, NavigationView.NavigationItemSelectedEventArgs e) =>
			{
				e.MenuItem.SetChecked(true);
				mDrawerLayout.CloseDrawers();
			};
		}

		public class TabAdapter : FragmentPagerAdapter

		{ 
			public List<SupportFragment> Fragments { get; set; }
			public List<string> FragmentNames { get; set; }

			public TabAdapter(SupportFragmentManager sfm) : base(sfm)
			{
				Fragments = new List<SupportFragment>();
				FragmentNames = new List<string>();
			}

			public void AddFragment(SupportFragment fragment, string name)
			{
				Fragments.Add(fragment);
				FragmentNames.Add(name);		
			}
		
			public override int Count
			{
				get
				{
					return Fragments.Count;
				}
			}

			public override SupportFragment GetItem(int position)
			{
				return Fragments[position];
			}

			public override ICharSequence GetPageTitleFormatted(int position)
			{
				return new Java.Lang.String(FragmentNames[position]);
			}
		}
    }
}
