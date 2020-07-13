using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamApp.Customs;
using XamApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(EntryCustomRenderer))]
namespace XamApp.Droid
{
    internal class EntryCustomRenderer : EntryRenderer
    {
        public EntryCustomRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.Transparent, PorterDuff.Mode.SrcAtop);

            ColorStateList colors = Resources.GetColorStateList(Resource.Color.text_color_selector, Android.App.Application.Context.Theme);

            Control.SetTextColor(colors);
        }


    }
}