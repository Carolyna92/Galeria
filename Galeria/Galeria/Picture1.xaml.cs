using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Galeria
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Picture1 : ContentPage
	{
		public Picture1 ()
		{
			InitializeComponent ();
            var soni = new Image
            {
                Source = ImageSource.FromResource("Galeria.sonic.jpg")
            };
            Content = soni;
		}
	}
}