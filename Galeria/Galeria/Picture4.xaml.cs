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
	public partial class Picture4 : ContentPage
	{
		public Picture4 ()
		{
			InitializeComponent ();
            var camp = new Image
            {
                Source = ImageSource.FromResource("Galeria.campanita.jpg")

            };
            Content = camp;
        }
	}
}