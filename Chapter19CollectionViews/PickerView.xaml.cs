using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace Chapter19CollectionViews
{
	public partial class PickerView : ContentPage
	{
		public PickerView()
		{
			InitializeComponent();
		}

		public void OnPickerSelectedIndexChanged(object sender, EventArgs args)
		{
			System.Diagnostics.Debug.WriteLine("The selected index has changed  {0} ",localPicker.SelectedIndex);

			PropertyInfo propertyInfo = typeof(Keyboard).GetRuntimeProperty(localPicker.Items[localPicker.SelectedIndex]);

			entry.Keyboard = (Keyboard)propertyInfo.GetValue(null);
		}
	}
}
