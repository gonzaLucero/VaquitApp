using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaquitApp.Commons;
using Xamarin.Forms;

namespace VaquitApp.ViewModel
{
    public class BaseViewModel : NotificationObject
    {
        public bool IsBusy
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }

        public IToastControl Toast
        {
            get
            {
                return DependencyService.Get<IToastControl>();
            }
        }
    }
}
