using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Galeria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var imgn = new List<string>
            {
                "centro.jpg",
                "estrellapuebla.jpg",
                "a1.jpg",
                "familia.jpg",
                "amigos1.jpg",
                "https://cdn.muscleandstrength.com/sites/default/files/field/feature-image/workout/avengers-workout.jpg",

                "https://i.kinja-img.com/gawker-media/image/upload/s---T7KtiMN--/c_scale,fl_progressive,q_80,w_800/sscupt4gbtpqr0qojbxr.jpg"
            };
            Linea.ItemsSource = imgn;
        }

        private void NoMeGusta_Clicked(object sender, EventArgs e)
        {
            Me_gusta.Image = "like_11.png";
            No_megusta.Image = "dislike1.png";
        }

        private void MeGusta_Clicked_1(object sender, EventArgs e)
        {
            Me_gusta.Image = "like1.png";
            No_megusta.Image = "dislike11.png";
        }

        private void Linea_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Imagen1.Source = e.SelectedItem as string;
            Direccion.Text = e.SelectedItem as string;
            if (Imagen1 != e.SelectedItem)
            {
                Me_gusta.Image = "like_11.png"; 
                No_megusta.Image = "dislike11.png";
            }
        }

        private void Navegar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Imagenes());
        }
    }
}
