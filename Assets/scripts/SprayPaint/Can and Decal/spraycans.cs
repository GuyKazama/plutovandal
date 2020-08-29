using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spraycans : MonoBehaviour
{
    public int currentcan;
    public Transform[] cans;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changecan(int num)
    {
        currentcan = num;
        for(int i = 0; i < cans.Length; i++)
        {
            if (i == num)
                cans[i].gameObject.SetActive(true);
            else
                cans[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            changecan(0);
        }

        if (Input.GetKeyDown("2"))
        {
            changecan(1);
        }

        if (Input.GetKeyDown("3"))
        {
            changecan(2);
        }

        if (Input.GetKeyDown("4"))
        {
            changecan(3);
        }

        if (Input.GetKeyDown("5"))
        {
            changecan(4);
        }

    }
}
