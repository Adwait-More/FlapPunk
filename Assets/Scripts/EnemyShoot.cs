using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    // Update is called once per frame
    public Transform PlayerPos;
    [SerializeField] private float  bulletSpeed;
    public  static Vector3 respawnPos;
    void Awake()
    {
        respawnPos = Camera.main.ViewportToWorldPoint(new Vector3(-1f, 0.5f, 0));
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < respawnPos.x)
        {
            GameObject.Destroy(this.gameObject);
        }
        transform.Translate(PlayerPos.right * bulletSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D colliderInfo)
    {
        if (colliderInfo.CompareTag("Player"))
        {
            
            StaticInit.gameManager.GameOver();
        }
    }
    
   
        public GameObject Enemy;
        [SerializeField] private int spawnRate=5;
        [SerializeField] private int spawnCount = 5;
        [SerializeField] private Vector3 addVec;
        [SerializeField] private int row;
        [SerializeField] private int col;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        
        private IEnumerator SpawnEnemyRoutine()
        {
            int counter = 0;
            while (counter < spawnCount)
            {
            
                // 1. Calculate the spawn position slightly off-screen to the right
           
                Vector3 spawnPosition = new Vector3(StaticInit.screenRightEdge.x + 1f, Random.Range(-5f,5f), 0);

                // 2. Spawn the enemy
                Instantiate(Enemy, spawnPosition, Quaternion.identity);
                counter++;
                // 3. Pause the loop 
                yield return new WaitForSeconds(spawnRate);
            }
            StopCoroutine(SpawnEnemyRoutine());
        }
    }

