﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGuiaDevFatec.Droid
{
    [Activity(Label = "AppGuiaFatec",
              MainLauncher = true,
                NoHistory = true,
              Theme ="@style/MyTheme.Splash")]
    public class Splash_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here
        }
    }
}