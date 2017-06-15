using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;

namespace Monateng 
{
	[Activity(Label = "Monateng", MainLauncher = true, Icon = "@mipmap/icon")]
	public class SplashActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.SplashLayout);

			// Get our button from the layout resource,
			// and attach an event to it
			Task.Run(() =>
			{
				Thread.Sleep(2000);

				var intent = new Intent(this, typeof(SecActivity));

				StartActivity(intent);
			});
		
		}
	}
}
