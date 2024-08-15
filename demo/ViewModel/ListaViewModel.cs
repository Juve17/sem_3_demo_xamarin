using demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace demo.ViewModel
{
    public class ListaViewModel
    {
        public ObservableCollection <Lista> Listas { get; set; }
        public ListaViewModel()

        {
            Listas = new ObservableCollection<Lista>
            {
                new Lista { Name = "Juvenal", ImagenUrl = "https://www.metafrase.com/blog/wp-content/uploads/sites/4/2023/09/hacker-fb-dp-photo-9-jpg.webp" },
                new Lista { Name = "Prueba", ImagenUrl = "https://www.metafrase.com/blog/wp-content/uploads/sites/4/2023/09/hacker-fb-dp-photo-9-jpg.webp" }
            };
        }
    }
}
