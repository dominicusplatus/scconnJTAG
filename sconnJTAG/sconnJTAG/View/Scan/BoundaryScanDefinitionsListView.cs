using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace sconnJTAG.View
{
	public class BoundaryScanDefinitionsListView : ContentPage
	{
		public BoundaryScanDefinitionsListView ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}
