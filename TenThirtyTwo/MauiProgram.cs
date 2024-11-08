using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using Microsoft.Extensions.DependencyInjection;
using TenThirtyTwo.Models;



namespace TenThirtyTwo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            #if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            // Register UserInfo as a transient service
            builder.Services.AddTransient<UserInfo>();

            return builder.Build();
        }
    }
}
