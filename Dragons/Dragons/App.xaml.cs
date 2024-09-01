using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Dragons
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
  }

  public class PercentageConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (parameter == null)
        return 0.7 * (double)value;

      string[] split = parameter.ToString().Split('.');
      double split0;
      double.TryParse(split[0], out split0);
      double split1;
      double.TryParse(split[1], out split1);
      double parameterDouble = split0 + split1 / (Math.Pow(10, split[1].Length));
      return (double)value * parameterDouble;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // Don't need to implement this
      return null;
    }
  }
}
