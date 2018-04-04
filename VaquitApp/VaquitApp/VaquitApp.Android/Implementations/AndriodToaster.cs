
using Android.App;
using Android.Widget;
using VaquitApp.Commons;
using VaquitApp.Droid.Implementations;

[assembly: Xamarin.Forms.Dependency(typeof(AndriodToaster))]
namespace VaquitApp.Droid.Implementations
{
    public class AndriodToaster : IToastControl
    {
        public void ShowMessage(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}