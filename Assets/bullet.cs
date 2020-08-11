using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet: MonoBehaviour
{
    public GameObject gun;
    public GameObject mBullet;
    public float bulletForwardForce;
    public float nextFire;
    public float fireRate;
    private float myTime = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetKey("mouse 0") && myTime > nextFire)
        {
            nextFire = myTime + fireRate;
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(mBullet, gun.transform.position, gun.transform.rotation) as GameObject;

            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 10);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
            Temporary_RigidBody.AddForce(transform.forward * bulletForwardForce);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(Temporary_Bullet_Handler, 10.0f);

            nextFire = nextFire - myTime;
            myTime = 0.0f;
        }
    }
}
