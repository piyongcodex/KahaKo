using CommunityToolkit.Maui;
using KahaKo.Services;
using KahaKo.ViewModels;
using KahaKo.Views;
using Microsoft.Extensions.Logging;

namespace KahaKo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<AppShell>();

            // Register Services
            builder.Services.AddSingleton<DatabaseService>();
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddTransient<ProductService>();
            //builder.Services.AddTransient<TransactionService>();

            // Register ViewModels
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<DashboardViewModel>();
            builder.Services.AddTransient<ProductViewModel>();
            builder.Services.AddTransient<SalesViewModel>();

            // Register Views
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<DashboardPage>();
            //builder.Services.AddTransient<ProductManagementPage>();
            builder.Services.AddTransient<SalesPage>();

        }
    }
}
