using Android.Content;
using Android.OS;
using Android.Views.InputMethods;
using Android.Widget;
using LoginApp.CustomRenders;
using LoginApp.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace LoginApp.Droid.CustomRenders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.SetHintTextColor(Android.Graphics.Color.ParseColor("#737880"));

            }
        }
    }
}