using Foundation;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Embedding;
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
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
        // Register the Window
        builder.Services.Add(new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(typeof(UIWindow), Window));
        MauiApp mauiApp = builder.Build();
        _mauiContext = new MauiContext(mauiApp.Services);
        return true;
    }
}

