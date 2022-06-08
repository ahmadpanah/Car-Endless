using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{

    public float speed = 0.02f;

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
            rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0f);
        rend.material.mainTextureOffset = offset;
    }
}
