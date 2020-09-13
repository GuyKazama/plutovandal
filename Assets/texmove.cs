using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texmove : MonoBehaviour
{
    public Vector2 movement;
    private Renderer rend;
    private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        offset = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * movement;
        rend.material.SetTextureOffset("_MainTex", offset);

    }
}
