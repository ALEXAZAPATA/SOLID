class Personaje { 
    public string Nombre  {get; private set;}

    public int PuntosVida { get; protected set; }

    public bool EstadoVida {get{ return PuntosVida > 0; }}

    public Personaje(string nombre)
    {
        Nombre = nombre;
        PuntosVida = 100;
    }

    public void RecibirDano (int cantidad)
    {
        PuntosVida -= cantidad;
        if (PuntosVida < 0) PuntosVida = 0;
        System.Console.WwriteLine($"{Nombre} recibió un daño de {cantidad},sus puntos de vida son: {PuntosVida}");

    }

}
