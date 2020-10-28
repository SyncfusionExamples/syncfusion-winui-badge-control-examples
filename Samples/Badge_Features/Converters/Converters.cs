using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Notifications;

namespace Badge_Features
{
    public class StringToBadgeAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType.Name == "HorizontalAlignment")
            {
                if (value.ToString() == "Left")
                {
                    return HorizontalAlignment.Left;
                }
                else if (value.ToString() == "Center")
                {
                    return HorizontalAlignment.Center;
                }
                else if (value.ToString() == "Right")
                {
                    return HorizontalAlignment.Right;
                }
                else if (value.ToString() == "Stretch")
                {
                    return HorizontalAlignment.Stretch;
                }
                else
                {
                    return HorizontalAlignment.Right;
                }
            }
            else if (targetType.Name == "VerticalAlignment")
            {
                if (value.ToString() == "Top")
                {
                    return VerticalAlignment.Top;
                }
                else if (value.ToString() == "Center")
                {
                    return VerticalAlignment.Center;
                }
                else if (value.ToString() == "Bottom")
                {
                    return VerticalAlignment.Bottom;
                }
                else if (value.ToString() == "Stretch")
                {
                    return VerticalAlignment.Stretch;
                }
                else
                {
                    return VerticalAlignment.Top;
                }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToBadgeAnchorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == "Inside")
            {
                return BadgeAnchor.Inside;
            }
            else if (value.ToString() == "Center")
            {
                return BadgeAnchor.Center;
            }
            else if (value.ToString() == "Outside")
            {
                return BadgeAnchor.Outside;
            }
            else if (value.ToString() == "Custom")
            {
                return BadgeAnchor.Custom;
            }
            else
            {
                return BadgeAnchor.Center;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToBadgeFillConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == "Success")
            {
                return BadgeFill.Success;
            }
            else if (value.ToString() == "Warning")
            {
                return BadgeFill.Warning;
            }
            else if (value.ToString() == "Error")
            {
                return BadgeFill.Error;
            }
            else if (value.ToString() == "Information")
            {
                return BadgeFill.Information;
            }
            else if (value.ToString() == "Alt")
            {
                return BadgeFill.Alt;
            }
            else if (value.ToString() == "Accent")
            {
                return BadgeFill.Accent;
            }
            else
            {
                return BadgeFill.Default;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToBadgeShapeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == "Ellipse")
            {
                return BadgeShape.Ellipse;
            }
            else if (value.ToString() == "Oval")
            {
                return BadgeShape.Oval;
            }
            else if (value.ToString() == "Rectangle")
            {
                return BadgeShape.Rectangle;
            }
            else if (value.ToString() == "Custom")
            {
                return BadgeShape.Custom;
            }
            else if (value.ToString() == "None")
            {
                return BadgeShape.None;
            }
            else
            {
                return BadgeShape.Ellipse;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToAnimationTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == "Scale")
            {
                return AnimationType.Scale;
            }
            else if (value.ToString() == "Opacity")
            {
                return AnimationType.Opacity;
            }
            else
            {
                return AnimationType.None;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == "Collapsed")
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
