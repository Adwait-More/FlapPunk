
using System.Net.NetworkInformation;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    float Pos;
    Transform PipeTransform;
    public float PipeSpeed = 2f;
    [SerializeField] float RespawnXPosition;
   

    private Camera cam;
    
    int spawnSize;
    private PipeSpawnner spawnner;
    void Start()
    {
        spawnner = FindAnyObjectByType<PipeSpawnner>();
        cam = Camera.main;   
        PipeTransform =transform;
        RespawnXPosition = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x - 1f;
        spawnSize = spawnner.SpawnSize;
        
    }

    // Update is called once per frame
    void Update()
    {


        PipeTransform.position += Vector3.left * PipeSpeed * Time.deltaTime;
        if (PipeTransform.position.x <= RespawnXPosition)
        {
            PipeTransform.position = new Vector3(spawnner.PipeList[spawnner.pipeIndex].transform.position.x + spawnner.PipeDistance, Random.Range(3.53f, -3.19f), 0);
            if (spawnner.pipeIndex == spawnSize - 1)
            {
                spawnner.pipeIndex = 0;
            }
           else  if (spawnner.pipeIndex < spawnSize - 1)
            {
                spawnner.pipeIndex++;
            }

        }
    }
    public void DisableMovement()
    {
        PipeSpeed = 0f;
    }
}
