public class Zombie extends MobHostil {
    public Zombie(){
        super("zombie", 28);
    }

    @Override
    void atacar(){
        System.out.println("el zombie va hacia a ti y te daña con las manos");
    }
    
}
