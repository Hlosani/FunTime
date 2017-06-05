using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;
using Android.Animation;

namespace FunTime
{
	[Activity(Label = "FunTime", MainLauncher = true, Theme = "@style/MyTheme.Base")]
	public class WelcomeActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.welcome_layout);

			var imgView = FindViewById<ImageView>(Resource.Id.imageView1);

			Android.Animation.ObjectAnimator animatorX = Android.Animation.ObjectAnimator.OfFloat(imgView, "scaleX", 0.5f, 1f);
                 animatorX.SetDuration(2000);
				 animatorX.Start();

			Task.Run(() =>
			{	                                                                                                                                                                            
				Thread.Sleep(3000);

				var intent = new Intent(this, typeof(MainActivity));

				StartActivity(intent);
			});

		}
	}
}

