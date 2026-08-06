using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnner : MonoBehaviour
{

    public float UpperLimit = 3.53f, LowerLimit = -3.19f; 
    public int SpawnSize, PipeDistance = 5;
    public GameObject PipePrefab;
    [SerializeField]   float PipeSpeed = 2f;
    public List<GameObject> PipeList = new List<GameObject>();
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    { 
        
   
       
        for (int i = 0; i < SpawnSize; i++)
        {

           
            GameObject Pipe = Instantiate(PipePrefab, new Vector3( player.transform.position.x + i*PipeDistance +  PipeDistance, Random.Range(LowerLimit, UpperLimit), 0), Quaternion.identity); 
            Pipe.SetActive(true);
            PipeList.Add(Pipe);
            

        }
        



    }

    void Update()
    {
        foreach (GameObject Pipe in PipeList)
            Pipe.transform.position += Vector3.left * PipeSpeed * Time.deltaTime;
        
        
    }
    

} 