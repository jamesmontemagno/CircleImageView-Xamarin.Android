using Android.App;
using Android.Widget;
using Android.OS;

namespace CircleImageSample
{
    [Activity(Label = "CircleImageSample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            
            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };

            var imageView = FindViewById<ImageView>(Resource.Id.circleimage);
            Koush.UrlImageViewHelper.SetUrlDrawable (imageView, "https://s.gravatar.com/avatar/7d1f32b86a6076963e7beab73dddf7ca?s=300");
        }
    }
}


