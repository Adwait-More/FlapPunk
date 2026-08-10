using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PipeSpawnner : MonoBehaviour
{
    private GameObject frontPipe;
     float upperLimit = 3.53f, lowerLimit = -3.19f;
     [SerializeField] private int spawnSize=5; 
     [SerializeField] private   int pipeDistance = 5;
     [SerializeField] GameObject pipePrefab;
    [SerializeField]   float pipeSpeed = 2f;
    [SerializeField] List<GameObject> pipeList = new List<GameObject>();
    [SerializeField] GameObject player;
    float respawnPos;
[SerializeField]
    private float screenVar;
    // Start is called before the first frame update
    void Start()
    {
     
        respawnPos = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x-screenVar;
        for (int i = 0; i < spawnSize; i++)
        {
            GameObject Pipe = Instantiate(pipePrefab, new Vector3( player.transform.position.x + i*pipeDistance +  pipeDistance, Random.Range(lowerLimit, upperLimit), 0), Quaternion.identity); 
            Pipe.SetActive(true);
            pipeList.Add(Pipe);
        }
        
    }
    
    void Update()
    {
        foreach (GameObject Pipe in pipeList)
            Pipe.transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        if (pipeList[0].transform.position.x < respawnPos)
        {
            pipeList[0].transform.position= new Vector3(pipeList[spawnSize-1].transform.position.x+pipeDistance,Random.Range(lowerLimit,upperLimit),0);
            frontPipe = pipeList[0];
            pipeList.RemoveAt(0);
            pipeList.Add(frontPipe);
        }
    }
    
    public void DisablePipeMovement()
    {
        pipeSpeed = 0;
        enabled = false;
    }
}

