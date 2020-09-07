using UnityEngine;
using System.Collections;

public class billboard : MonoBehaviour
{
	//private Camera m_Camera;

	private Camera target;
	private Vector3 targetPoint;
    //private Vector3 myPos; 
    public float myRotationRandom;


	void Start()
	{
        //m_Camera = Camera.main;
        target = Camera.main;
        //targetPoint = target.transform.position;
        //targetPoint.y = this.gameObject.transform.position.y;
        myRotationRandom = Random.Range(-myRotationRandom, myRotationRandom);
        //myPos = Camera.main.transform.position;
    }
	void Update()
	{
		targetPoint = target.transform.position;
		//targetPoint.y = this.gameObject.transform.position.y;
		////transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back, m_Camera.transform.rotation * Vector3.up); //This Rotates them with the camera
		transform.LookAt(targetPoint, (Camera.main.transform.up).normalized);
        transform.Rotate(transform.forward, myRotationRandom);




        //transform.rotation = Quaternion.LookRotation(this.gameObject.transform.position-targetPoint);

    }
}