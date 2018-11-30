using Android.App;
using Android.Content.PM;
using Android.OS;
using AutomationTest.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace AutomationTest.Droid.Resources.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class HomeView : MvxAppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.main);
            //AppCenter.Start("d07c90c9-8d1a-48e7-b165-e297d7c793c6", typeof(Analytics), typeof(Crashes));
        }
    }
}