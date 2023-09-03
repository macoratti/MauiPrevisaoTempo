using MauiPrevisaoTempo.Models;
using MauiPrevisaoTempo.Services;

namespace MauiPrevisaoTempo;

public partial class MainPage : ContentPage
{
    private readonly IRestService _restService;
    public MainPage(IRestService restService)
    {
        InitializeComponent();
        _restService = restService;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_cidade.Text))
        {
            WeatherData weatherData = await
                _restService.
                GetWeatherData(GenerateRequestURL(Constants.OpenWeatherMapEndpoint));

            BindingContext = weatherData;
        }
    }

    private string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?q={_cidade.Text}";
        requestUri += "&units=metric";
        requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
        requestUri += $"&lang=pt_br";
        return requestUri;
    }
}