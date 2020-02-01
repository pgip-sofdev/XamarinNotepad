using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace XAMARIN_NOTEPAD_77
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class MainActivity : AppCompatActivity
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public MainActivity(TextView textView)
        {
            TextView1 = textView ?? throw new ArgumentNullException(nameof(textView));
        }

        public TextView TextView { get; private set; }
        public Android.Support.V7.Widget.Toolbar toolbar { get; private set; }

        public TextView TextView1 { get; }

        public int Text1 { get; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            NewMethod3(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            TextView = FindViewById<TextView>(Resource.Id.textView1);

            object p1 = NewMethod();
            object p = p1;
            FindViewById<Button>(Resource.Id.btnSave).Click += (o, e) =>


            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        private void NewMethod3(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        private object NewMethod()
        {
            object p1 = NewMethod1();
            return p1;
        }

        private object NewMethod1()
        {
            object p1 = NewMethod2();
            return p1;
        }

        private object NewMethod2()
        {
            object p1 = NewMethod();
            return p1;
        }

        private object FindViewById<T>()
        {
            throw new NotImplementedException();
        }

        private T FindViewById<T>(object textView)
        {
            throw new NotImplementedException();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public override bool Equals(object obj)
        {
            var activity = obj as MainActivity;
            return activity != null &&
                   EqualityComparer<TextView>.Default.Equals(TextView1, activity.TextView1);
        }
    }
}

