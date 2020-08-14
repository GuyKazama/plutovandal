using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //initial speed
    public int speed = 20;

    public bool canMove = true;
    float rotationX = 0;
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    public float jumpSpeed = 8.0f;
    public float gravity = 0.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public Rigidbody player;
    
 
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Rigidbody.velocity = speed;

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);

        }


        //press shift to move faster
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 40;

        }
        else
        {
            //if shift is not pressed, reset to default speed
            speed = 20;
        }
        //For the following 'if statements' don't include 'else if', so that the user can press multiple buttons at the same time
        //move camera to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Camera.main.transform.right * -1 * speed * Time.deltaTime;
        }

        //move camera backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Camera.main.transform.forward * -1 * speed * Time.deltaTime;

        }
        //move camera to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;

        }
        //move camera forward
        if (Input.GetKey(KeyCode.W))
        {

            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
        //move camera upwards
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = transform.position + Camera.main.transform.up * speed * Time.deltaTime;
        }
        //move camera downwards
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + Camera.main.transform.up * -1 * speed * Time.deltaTime;
        }

    }
}
