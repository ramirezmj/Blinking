﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Blinking.Converters
{
	class ButtonConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			
			string actualValue = "Close";
			if (((bool)value) == true)
			{
				actualValue = "Open";
			}
			return actualValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return value.ToString();
		}
	}
}
