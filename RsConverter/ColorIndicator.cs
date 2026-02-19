using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace LCPReportingSystem.RsConverter
{
    public class ColorIndicator : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color;
            SolidColorBrush solidColorBrush = new SolidColorBrush();
            string Result = (string)value;
            string HexCodes = string.Empty;
            if (!string.IsNullOrEmpty(Result))
            {
                switch (Result)
                {
                    case "red":
                        HexCodes = "#FF0000";
                        break;
                    case "green":
                        HexCodes = "#008000";
                        break;
                    case "amber":
                        HexCodes = "#F78103";
                        break;
                    case "gray":
                        HexCodes = "#808080";
                        break;
                    case "MenuActive":
                        HexCodes = "#2969BB";
                        break;
                    case "MenuInactive":
                        HexCodes = "#39525E";
                        break;
                }

                if (!string.IsNullOrEmpty(HexCodes))
                {
                    switch (HexCodes)
                    {
                        case "#FF0000":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                        case "#F78103":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                        case "#008000":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                        case "#808080":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                        case "#2969BB":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                        case "#39525E":
                            color = (Color)ColorConverter.ConvertFromString(HexCodes);
                            solidColorBrush.Color = color;
                            break;
                    }
                }
            }
            return solidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
