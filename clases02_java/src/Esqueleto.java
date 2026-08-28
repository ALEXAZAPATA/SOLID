public class Esqueleto extends MobHostil {
    public Esqueleto(){
        super("Esqueleto", 28);
    }

    @Override
    void atacar(){
        System.out.println("el esqueleto va hacia a ti y te daña con las manos");
    }
    
}
