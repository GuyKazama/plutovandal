using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public int debrisNumber = 10;
    public GameObject debris;
    public float explosionForce = 5;
    public float upfactor;
    public float debrisScale;
    public GameObject explode;

    void Start()
    {
        for (int i = 0; i < debrisNumber; i++)
        {
            GameObject go = Instantiate(debris) as GameObject;
            go.GetComponent<Rigidbody>().velocity = (Random.insideUnitSphere * explosionForce) + (Vector3.up * upfactor);
            go.transform.position = transform.position;
            go.transform.parent = transform;
            go.transform.localScale = (Random.Range(0, debrisScale) * Vector3.one);
            go.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explode);
        }
    }
}
