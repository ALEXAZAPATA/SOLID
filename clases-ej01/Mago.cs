using System;
using System.Collections.Generic;
using System.Text;

namespace clases_ej01
{
    class Mago
    {
        public Mago(string nombre) : base(nombre)
        { }
        public override void Ataque(Personaje objetivo)
        {
            System.Console.WriteLine($"{nombre} ataca con la espada");
            objetivo.RecibirDano(15);
        }

        public void UsarHabilidadad()
        {
            puntosVida += 30;
            if(puntosVida > 100) puntosVida = 100;

        }
    }
}
