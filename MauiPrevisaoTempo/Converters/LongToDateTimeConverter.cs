using System.Globalization;

namespace MauiPrevisaoTempo.Converters;

public class LongToDateTimeConverter : IValueConverter
{
    DateTime _time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        // Defina a cultura como "pt-BR"
        CultureInfo ptBrCulture = new CultureInfo("pt-BR");

        long dateTime = (long)value;
        return $"{_time.AddSeconds(dateTime).ToString(ptBrCulture)} UTC";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
