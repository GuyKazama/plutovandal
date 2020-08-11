using UnityEngine;

public class raycastpaint : MonoBehaviour
{
    public GameObject Paint;
    public GameObject Spraycan;
    
    
    
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void Update()
    {
        if (Input.GetKey("e"))
        {
            //shorthand so I don't need to write that out everytime
            //Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Debug.DrawLine(Vector3.zero, Vector3.forward * 100);
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            //draws line 10 units in front of player
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.tag == "taggable surface")
                {
                    Instantiate(Paint, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                    //print("There is something in front of the object!");

                }
            }
        }
       // if (Physics.Raycast(transform.position, fwd, 10))
         //   print("There is something in front of the object!");
    }
}