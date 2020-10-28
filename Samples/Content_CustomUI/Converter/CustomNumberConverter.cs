using Microsoft.UI.Xaml.Data;
using System;

namespace Content_CustomUI
{
    public class CustomNumberConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (int.TryParse(value.ToString(), out int number)) {
                if (number <= 99) {
                    return value;
                }
                else if (number <= 999) {
                    return "99+";
                }
                else if (number < 99999) {
                    return (number / 1000).ToString("0.#") + "K";
                }
                else if (number < 999999) {
                    return (number / 1000).ToString("#,0K");
                }
                else if (number < 9999999) {
                    return (number / 1000000).ToString("0.#") + "M";
                }
                else {
                    return (number / 1000000).ToString("#,0M");
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
