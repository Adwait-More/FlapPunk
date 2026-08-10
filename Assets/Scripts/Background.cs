using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float scrollSpeed = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset += new Vector2(scrollSpeed, 0) * Time.deltaTime;
    }
}
