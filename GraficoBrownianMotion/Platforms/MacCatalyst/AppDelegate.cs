using Foundation;
using Microsoft.Maui.Hosting;
using UIKit;

namespace GraficoBrownianMotion;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    MauiContext? _mauiContext;

    public override UIWindow? Window
    {
        get;
        set;
    }
    MauiAppBuilder builder = MauiApp.CreateBuilder();
    
}

