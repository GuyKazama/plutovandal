using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyafterseconds : MonoBehaviour
{
    public float seconds = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, seconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
