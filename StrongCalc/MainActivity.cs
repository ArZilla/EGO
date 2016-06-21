using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace StrongCalc
{
    [Activity(Label = "StrongCalc", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            var distance = FindViewById<EditText>(Resource.Id.distance);
            var fuelConsumption = FindViewById<EditText>(Resource.Id.fuelConsumption);
            var fuelCosts = FindViewById<EditText>(Resource.Id.fuelCosts);
            var result = FindViewById<TextView>(Resource.Id.result);

            calculateButton.Click += (sender, args) =>
            {
                if (String.IsNullOrEmpty(distance.Text) || String.IsNullOrEmpty(fuelConsumption.Text) ||
                    String.IsNullOrEmpty(fuelCosts.Text)) return;

                float dist, cons, cost;
                float x = 100;
                if (!float.TryParse(distance.Text, out dist))
                    return;
                if (!float.TryParse(fuelConsumption.Text, out cons))
                    return;
                if (!float.TryParse(fuelCosts.Text, out cost))
                    return;
                result.Text = (((dist/x)*cons)*cost).ToString();

            };
        }
    }
}

