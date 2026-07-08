using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeSpawnner : MonoBehaviour
{
    public float UpperLimit = 3.53f;
    public float LowerLimit = -3.19f;
    public int SpawnSize;
    public float LastPipeX;


    List<GameObject> Pipes = new List<GameObject>();
    public GameObject PipePrefab;

    List<GameObject> PipeList = new List<GameObject>();
    int i;


    // Start is called before the first frame update
    void Start()
    {

        for (i = 0; i < SpawnSize; i++)
        {

            Pipes.Add(PipePrefab);
            GameObject Pipe = Instantiate(PipePrefab, new Vector3(5 + i * 5, Random.Range(LowerLimit, UpperLimit), 0), Quaternion.identity);
            Pipe.SetActive(true);
            PipeList.Add(Pipe);


        }
        LastPipeX = PipeList[^1].transform.position.x;



    }

}