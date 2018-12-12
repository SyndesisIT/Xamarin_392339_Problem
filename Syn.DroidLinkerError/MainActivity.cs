using Microsoft.Extensions.Logging;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Auth;
using System;
using System.Collections;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

using System.Threading.Tasks;

using Android.Net;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using System.Drawing;
using Android.Graphics.Drawables;


namespace Syn.DroidLinkerError
{
    [Activity(Label = ConstantsHelper.AppName, MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = (Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize))]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.test_activity);


            Button button = FindViewById<Button>(Resource.Id.TranslateButton);
            button.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var db =  DbFactory.GetUnitOfWork(this);

            var obj = new Unatec.SEOS.Discharges.Runnable.Droid.Model.Cander()
            {
                Name = $"Cander {DateTime.Now.Ticks}"
            };
            db.Test.Add(obj);

            if (db.SaveChanges() != 0)
            {
                TextView textView = FindViewById<TextView>(Resource.Id.TextTranslated);
                textView.Text = $"Se ha insertado correctamente con Id:{obj.Id}"; 
            }
        }
    }
}
