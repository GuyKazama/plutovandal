using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAsteroidField : MonoBehaviour
{
    public GameObject asteroid;
    public int numberOfAsteroids = 200;
    public Vector3 range = new Vector3(10,10,10);
    public float holeRadius = 0;
    public bool maintainAspectRatio = false;
    public Vector3 minScale = new Vector3(0.5f,0.5f,0.5f);
    public Vector3 sizeVariance = Vector3.zero;
    public Vector3 rotationVariance = new Vector3(180,180,180);
    public bool drift = true;
    public float driftStrength = 1.0f;
    public float rotationDriftStrength = 1.0f;
    public float flatness = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<numberOfAsteroids; i++)
        {
            GameObject go = Instantiate(asteroid) as GameObject;
            Vector3 positionOffset = Vector3.Scale(range, Random.insideUnitSphere);
            positionOffset.y /= flatness;

            if (positionOffset.magnitude < holeRadius)
            {
                positionOffset = positionOffset.normalized * Random.Range(holeRadius,range.x);
            }

            if (positionOffset.y < -range.y/flatness || positionOffset.y > range.y/flatness)
            {
                positionOffset.y /= flatness;
            }

            go.transform.position = transform.position + positionOffset;
            go.transform.parent = transform;

            if (maintainAspectRatio)
            {
                go.transform.localScale = minScale + Vector3.one * Random.Range(-1.0f, sizeVariance.x);
            }
            else
            {
                go.transform.localScale = minScale + Vector3.one + Vector3.Scale(sizeVariance, Random.insideUnitSphere);
            }
            go.transform.Rotate(Vector3.Scale(rotationVariance, Random.insideUnitSphere));
            if (drift)
            {
                go.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * driftStrength);
                go.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * rotationDriftStrength);
            }
        }
    }
}
