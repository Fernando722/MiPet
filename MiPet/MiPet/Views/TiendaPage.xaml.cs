using MiPet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPet.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TiendaPage : ContentPage
	{
		public TiendaPage ()
		{
			InitializeComponent ();
            CargarProductos();
        }

        private void CargarProductos()
        {
            var listado = new List<Producto>
           {
               new Producto{ Nombre="Guacal", Descripcion="Guacal para gato", Precio="$120.000", Imagen="guacal.jpg"},
               new Producto{ Nombre="Adore", Descripcion="Cuido para gato premium", Precio="$50.000", Imagen="adore.jpg"},
               new Producto{ Nombre="Arena Free Miau", Descripcion="Arena para gato", Precio="$35.000", Imagen="arenafreemiau.jpg"},
               new Producto{ Nombre="Arenero", Descripcion="Arenero color varios", Precio="$80.000", Imagen="arenero.jpg"},
               new Producto{ Nombre="Calming", Descripcion="Cuido para cuidar el higado de tu mascota", Precio="$65.000", Imagen="calming.jpg"},
               new Producto{ Nombre="Cocodrilo", Descripcion="Juguete para mascotas", Precio="$12.000", Imagen="cocodrilo.jpg"},
               new Producto{ Nombre="Dog-Choc", Descripcion="Chocolate para mascotas", Precio="$10.000", Imagen="dogchoc.jpg"},
               new Producto{ Nombre="Esencia", Descripcion="Esencia aquí no", Precio="$40.000", Imagen="esencia.jpg"},
               new Producto{ Nombre="Gel", Descripcion="Gel para el cuidado de la boca de tu mascota", Precio="$12.000", Imagen="gel.jpg"},
               new Producto{ Nombre="Pañales", Descripcion="Pañales para perro", Precio="$45.000", Imagen="panales.jpg"}
           };

            listProductos.ItemsSource = listado;
        }

        private async void Producto_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = (Producto)e.SelectedItem;
            await Navigation.PushAsync(new DetallePage(producto));
        }

    }
}