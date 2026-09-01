using UnityEngine;

public  class  EnemySpawnner : MonoBehaviour
{
    public GameObject Eenmy;

    [SerializeField] private int row;
    [SerializeField] private int col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
  public  void Spawn()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Instantiate(Eenmy, new Vector3(transform.position.x + j, transform.position.y+i, transform.position.z), transform.rotation);
            }
        }
    }
}
