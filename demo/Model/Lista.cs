using System;
using System.Collections.Generic;
using System.Text;

namespace demo.Model
{
    public class Lista
    {
        public string Name { get; set; }
        public string ImagenUrl {  get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
