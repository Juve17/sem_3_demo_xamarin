using demo.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listas : ContentPage
    {
        public Listas()
        {
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Lista selectedItem = e.CurrentSelection[0] as Lista;
            //opcion 1
            //await DisplayAlert("Alert", "Esta es una alerta", "ok");
            //opcion 2
            /* bool response = await DisplayAlert("Guardar?", "Este es un mensaje de prueba", "Si", "No");
             Console.WriteLine(response);*/
            string action = await DisplayActionSheet("Guarda?", "Cancel", null, "Facebook", "Tiktok", "Email");
            Console.WriteLine(action);
        }
    }
}