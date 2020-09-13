using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeOnHit : MonoBehaviour
{
    public GameObject hitexplode;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(hitexplode, position, rotation);
        Destroy(gameObject);
        //go.transform.position = transform.position;
        //go.transform.parent = transform;
    }
}
