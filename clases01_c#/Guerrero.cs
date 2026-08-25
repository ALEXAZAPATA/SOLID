using System;
using System.Collections.Generic;
using System.Text;

namespace clases_ej01
{
     class Guerrero
    {
        public Guerrero (String nombre) : base(nombre)
        {

        }

        public override void Ataque(Personaje objetivo)
        {
            System.Console.WriteLine($"{nombre} ataca con la espada a {objetivo.nombre}");

        }
    }
}
