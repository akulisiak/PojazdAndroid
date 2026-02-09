using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Collections.Generic;

namespace PojazdAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public List<Pojazd> listaPojazdow = new List<Pojazd> {
            new Samochod(4, "Toyota", 2010),
            new Motocykl(true, "Harley-Davidson", 1975),
            new Samochod(2, "Mazda", 2015),
            new Motocykl(false, "Yamaha", 2020),
            new Samochod(2, "Volvo", 2024),
            new Motocykl(false, "BMW", 2021)
        };

        List<string> listaNazw = new List<string>();

        ListView pojazdyListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            pojazdyListView = FindViewById<ListView>(Resource.Id.listView1);

            foreach (Pojazd p in listaPojazdow)
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