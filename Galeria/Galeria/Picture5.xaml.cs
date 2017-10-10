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
	public partial class Picture5 : ContentPage
	{
		public Picture5 ()
		{
			InitializeComponent ();
            var h_a = new Image
            {
                Source = ImageSource.FromResource("Galeria.adventure-time.jpg")

            };
            Content = h_a;
        }
	}
}