

using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    
    Transform PipeTransform;
    [SerializeField]   float PipeSpeed = 2f;
    [SerializeField] float RespawnXPosition;
    private Camera cam;
   [SerializeField] int spawnSize;
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


       
        if (PipeTransform.position.x <= RespawnXPosition)
        {
            //PipeTransform.position = new Vector3(spawnner.PipeList[spawnner.pipeIndex].transform.position.x + spawnner.PipeDistance, Random.Range(PipeSpawnner.LowerLimit,PipeSpawnner.UpperLimit), 0);


          
        }
    }
    public void DisableMovement()
    {
        PipeSpeed = 0f;
    }
}
