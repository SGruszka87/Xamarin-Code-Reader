using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XfBarCode.Droid
{
    [Activity(Label = "XfBarCode", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public event XfBarCode.handler DeviceKeyPressed;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }




        public override bool DispatchKeyEvent(KeyEvent e)
        {
            bool bRet = true;
            if (e.Characters != null)
            {
                bRet = DeviceKeyPressed(e?.Characters?.ToString() ?? "", "EAN");

            }
            else
            {
                if (e.IsCanceled == false && e.DownTime == e.EventTime && e.ScanCode != 0)
                {
                    bRet = DeviceKeyPressed(e.KeyCode.ToString(), null);
                }
            }
            if (bRet)
            {
                bRet = base.DispatchKeyEvent(e);
            }
            return bRet;
        }
    }
}