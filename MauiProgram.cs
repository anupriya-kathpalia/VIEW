using Microsoft.Extensions.Logging;
using VIEW.Views;
using VIEW.ViewModels;


namespace VIEW
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            //views
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<DashboardPage>();
            

            //viewmodels
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<DashboardPageViewModel>();
            


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
