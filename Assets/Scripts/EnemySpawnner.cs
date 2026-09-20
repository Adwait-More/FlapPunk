using System.Collections;
using UnityEngine;

public class EnemySpawnner : MonoBehaviour
{
    public GameObject Enemy;
    [SerializeField] private int spawnRate=5;
    [SerializeField] private int spawnCount = 5;
    [SerializeField] private Vector3 addVec;
    [SerializeField] private int row;
    [SerializeField] private int col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        Debug.Log("HELOO");
        transform.position = StaticInit.screenRightEdge + addVec;
    }

   public void StartInvasion()
    {
            StartCoroutine(SpawnEnemyRoutine());
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        int counter = 0;
        while (counter < spawnCount)
        {
            
            // 1. Calculate the spawn position slightly off-screen to the right
           
            Vector3 spawnPosition = new Vector3(StaticInit.screenRightEdge.x + 1f, 0, 0);

            // 2. Spawn the enemy
            Instantiate(Enemy, spawnPosition, Quaternion.identity);
            counter++;
            // 3. Pause the loop 
            yield return new WaitForSeconds(spawnRate);
        }
        StopCoroutine(SpawnEnemyRoutine());
    }
}