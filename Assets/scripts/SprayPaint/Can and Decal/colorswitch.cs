using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorswitch : MonoBehaviour
{
    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            var main = ps.main;
            main.startColor = Color.white;
        }

    //    if (Input.GetKeyDown("2"))
    //    {
    //        var main = ps.main;
    //        main.startColor = Color.red;
    //    }

    //    if (Input.GetKeyDown("3"))
    //    {
    //        var main = ps.main;
    //        main.startColor = Color.green;
    //    }

    //    if (Input.GetKeyDown("4"))
    //    {
    //        var main = ps.main;
    //        main.startColor = Color.blue;
    //    }

    //    if (Input.GetKeyDown("5"))
    //    {
    //        var main = ps.main;
    //        main.startColor = Color.black;
    //    }

    }
}
