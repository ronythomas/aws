using System;
using Android.App;

namespace AroundMe.Android.Views
{
    [Application(Theme = "@android:style/Theme.Holo.Light")]
    public class AroundMeApplication : Application
    {
        public static Activity CurrentActivity { get; set; }
        public AroundMeApplication(IntPtr handle, global::Android.Runtime.JniHandleOwnership transer) : base(handle, transer) { }

        public override void OnCreate()
        {
            base.OnCreate();
//            CurrentPlatform.Init();
            // ServiceRegistrar.Startup();

        }
    }
}