using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidTrackuest
{
    [Activity(Label = "Tracquest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            PopulateAutoCompleteSuggestions();
        }

        private void PopulateAutoCompleteSuggestions()
        {
            ArrayAdapter<string> autoCompleteAdapter = new ArrayAdapter<string>(this,
                 Android.Resource.Layout.SimpleDropDownItem1Line, SONGS);
            AutoCompleteTextView textView = (AutoCompleteTextView)FindViewById(Resource.Id.titleAutoComplete);
            textView.Adapter = autoCompleteAdapter;
        }

        private static readonly string[] SONGS = new string[] { "BeWhy - Forever", "Big Bang - FXXK IT", "The Weeknd - Starboy", "Big Bang - Lies" };
    }
}

