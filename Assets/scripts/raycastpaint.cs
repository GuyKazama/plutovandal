using UnityEngine;

public class raycastpaint : MonoBehaviour
{
    public GameObject Paint;
    public GameObject Spraycan;
 

    void Update()
    {
        if (Input.GetKey("e"))
        {
            //ray out from the position of the mouse on the screen
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            //draws line 10 units in front of player
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                //maybe could do without this. was following a tutorial, figured it might be nice to have around if we want surfaces that react differently to paint
                if (hitInfo.collider.tag == "taggable surface")
                {
                    //creates gameobject "paint" on whatever surface the ray collided with. hitinfo.normal is the orientation in the world
                    Instantiate(Paint, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                    //print("There is something in front of the object!");

                }
            }
        }

      //  if ()
       // {
       //
       // }
    }
}