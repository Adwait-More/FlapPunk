using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float ScrollSpeed = 0.5f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset += new Vector2(ScrollSpeed, 0) * Time.deltaTime;
    }
}
