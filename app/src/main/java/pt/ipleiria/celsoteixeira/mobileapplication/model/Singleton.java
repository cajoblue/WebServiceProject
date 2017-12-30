package pt.ipleiria.celsoteixeira.mobileapplication.model;

/**
 * Created by celsoTeixeira on 12/19/2017.
 */

public class Singleton {
    private static final Singleton ourInstance = new Singleton();

    public static Singleton getInstance() {
        return ourInstance;
    }

    private Singleton() {
        this. bloodCrowd=new BloodCrowd();
    }
    private BloodCrowd bloodCrowd;


    public BloodCrowd getBloodCrowd() {
        return bloodCrowd;
    }

    public void setBloodCrowd(BloodCrowd bloodCrowd) {
        this.bloodCrowd = bloodCrowd;
    }
}
