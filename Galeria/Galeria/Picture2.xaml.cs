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
	public partial class Picture2 : ContentPage
	{
		public Picture2 ()
		{
			InitializeComponent ();
            var mb = new Image
            {
                Source = ImageSource.FromResource("Galeria.mario_bros.jpg")

            };
            Content =mb;
        }
	}
}