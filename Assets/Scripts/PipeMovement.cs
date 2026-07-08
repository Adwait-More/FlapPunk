using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    float Pos;
    Transform PipeTransform;
    public float PipeSpeed = 2f;
    [SerializeField] float RespawnXPosition = 10f;



    void Start()
    {
        PipeTransform=transform;

        Pos = FindAnyObjectByType<PipeSpawnner>().LastPipeX;
    }

    // Update is called once per frame
    void Update()
    {
       

        PipeTransform.position += Vector3.left * PipeSpeed * Time.deltaTime;
        if (PipeTransform.position.x <= RespawnXPosition)
        {
            PipeTransform.position = new Vector3(Pos-1.73f, Random.Range(3.53f, -3.19f), 0);
        }
          
    }
    public void DisableMovement()
    {
        PipeSpeed = 0f;
    }
}
