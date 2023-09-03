using MauiPrevisaoTempo.Services;

namespace MauiPrevisaoTempo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        IServiceCollection services = new ServiceCollection();
        services.AddTransient<IRestService, RestService>();
        var serviceProvider = services.BuildServiceProvider();

        MainPage = new MainPage(serviceProvider.GetService<IRestService>());
    }
}