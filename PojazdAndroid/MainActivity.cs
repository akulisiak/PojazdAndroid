using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using PojazdAndroid.Model;
using System.Collections.Generic;

namespace PojazdAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    { 
        List<string> listaNazw = new List<string>();

        ListView pojazdyListView;
        ImageButton addButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            pojazdyListView = FindViewById<ListView>(Resource.Id.listView1);
            addButton = FindViewById<ImageButton>(Resource.Id.imageButton1);
            addButton.Click += AddButton_Click;

            foreach (Pojazd p in BazaPojazdow.listaPojazdow)
            {
                listaNazw.Add(p.OpisShort());
            }

            pojazdyListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, listaNazw);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AddActivity));
            StartActivity(intent);
        }

        protected override void OnResume()
        {
            base.OnResume();
            listaNazw.Clear();
            foreach (Pojazd p in BazaPojazdow.listaPojazdow)
            {
                listaNazw.Add(p.OpisShort());
            }

            pojazdyListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, listaNazw);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}