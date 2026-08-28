public class Piston implements ActivablePorRedstone{
    @Override
    public void activar(){
        System.out.println("piston se activa");
    }
    @Override
    public void desactivar(){
        System.out.println("piston se desactiva");
    }
}
