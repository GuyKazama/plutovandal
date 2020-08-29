using UnityEngine;

public class raycastpaint : MonoBehaviour
{


   // public float currentpaint;
    public GameObject paint;


    //public void changepaint(int num)
    //{
    //    currentpaint = num;
    //    for(int i = 0; i < paints.Length; i++)
    //    {
    //        if (i == num)
    //            paints[i].gameObject.SetActive(true);
    //        else
    //            paints[i].gameObject.SetActive(false);
    //    }
    //}

    void Start()
    {
    }
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            paint = GameObject.FindGameObjectWithTag("paint_white");
        }

        if (Input.GetKeyDown("2"))
        {
            paint = GameObject.FindGameObjectWithTag("paint_red");
        }

        if (Input.GetKeyDown("3"))
        {
            paint = GameObject.FindGameObjectWithTag("paint_green");
        }

        if (Input.GetKeyDown("4"))
        {
            paint = GameObject.FindGameObjectWithTag("paint_blue");
        }

        if (Input.GetKeyDown("5"))
        {
            paint = GameObject.FindGameObjectWithTag("paint_black");
        }


        if (Input.GetMouseButton(0))
        {
            //spray.SetActive(true);
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
                    Instantiate(paint, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                    //print("There is something in front of the object!");

                }
            }
            
        }
        //if (Input.GetKeyUp("e"))
        //{
        //    spray.SetActive(false);
        //}
    }
}