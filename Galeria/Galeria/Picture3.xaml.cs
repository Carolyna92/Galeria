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
	public partial class Picture3 : ContentPage
	{
		public Picture3 ()
		{
			InitializeComponent ();
            var dino = new Image
            {
                Source = ImageSource.FromResource("Galeria.dinosaurio_1.jpg")

            };
            Content = dino;
        }
	}
}