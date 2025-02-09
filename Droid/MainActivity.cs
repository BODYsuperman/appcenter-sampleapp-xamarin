﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace sampleAppXamarin.Droid
{
    [Activity(Label = "AC Sample App", Icon = "@drawable/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
            
            public class Point 
            {
                public int X { get; init;}
                public int Y { get; init;}
            }
            
            var p2 = new Point
            {
                X = 42,
                Y = 30
            };
            
            Console.writeline($"p2.X")
            
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }
     
        
       
    }
}
