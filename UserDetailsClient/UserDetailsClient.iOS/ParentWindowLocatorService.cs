using Microsoft.Identity.Client;
using UIKit;
using UserDetailsClient.Core.Features.LogOn;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserDetailsClient.iOS.ParentWindowLocatorService))]
namespace UserDetailsClient.iOS
{
    class ParentWindowLocatorService : IParentWindowLocatorService
    {
        public object GetCurrentParentWindow()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            
            return vc;
        }
    }
}