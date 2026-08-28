public class Lampara implements ActivablePorRedstone{
    @Override
    public void activar(){
        System.out.println("lampara se enciende");
    }
    @Override
    public void desactivar(){
        System.out.println("lampara se apaga");
    }
}
