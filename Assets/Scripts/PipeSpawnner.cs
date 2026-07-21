using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnner : MonoBehaviour
{

    public float UpperLimit = 3.53f, LowerLimit = -3.19f, LastPipeX;

    public int SpawnSize, PipeDistance = 5;
    private Camera cam;

    public float spawnpos;
    [SerializeField]
    public List<GameObject> Pipes = new List<GameObject>();
    public GameObject PipePrefab;

    public List<GameObject> PipeList = new List<GameObject>();
   
    public int pipeIndex;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    { 
        pipeIndex=SpawnSize- 1;
        cam = Camera.main;
        spawnpos = player.transform.position.x;
        for (int i = 0; i < SpawnSize; i++)
        {

            Pipes.Add(PipePrefab);
            GameObject Pipe = Instantiate(PipePrefab, new Vector3( spawnpos + i*PipeDistance +  PipeDistance, Random.Range(LowerLimit, UpperLimit), 0), Quaternion.identity); 
            Pipe.SetActive(true);
            PipeList.Add(Pipe);
            

        }
        



    }
    

} 