public class BloqueMusical implements ActivablePorRedstone{
    @Override
    public void activar(){
        System.out.println("bloque recibe señal");
    }
    @Override
    public void desactivar(){
        System.out.println("se deja de reproducir musica");
    }
}
