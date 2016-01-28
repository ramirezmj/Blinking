using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Blinking.Converters
{
	class ImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			
			string actualValue = "/Assets/icon-eye-open.png";

			if (((bool)value) == true)
			{
					actualValue = "/Assets/icon-eye-close.png";
			}
			return actualValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return value.ToString();
		}
	}
}
