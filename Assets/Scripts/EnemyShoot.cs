using System.Collections;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    // Update is called once per frame
    public Transform PlayerPos;
    [SerializeField] private float bulletSpeed;
    public static Vector3 respawnPos;
    public float BulletspawnRate;

    void Start()
    {
        StartCoroutine(SpawnEnemyBulletRoutine());
    }
    void Awake()
    {
        respawnPos = Camera.main.ViewportToWorldPoint(new Vector3(-1f, 0.5f, 0));
    }
    // Update is called once per frame
    public GameObject bulletPrefab;
    public Vector3 spawnPos;
    public void ShootEnemyBullet()
    {
        StaticInit.AudioManager.PlayShootSound();
        spawnPos = new Vector3(transform.position.x-0.2f, transform.position.y, transform.position.z);   
        GameObject bullet= Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
        bullet.GetComponent<BulletScript>().ISEnemyBullet = true;
       
        bullet.SetActive(true);
    }
    private IEnumerator SpawnEnemyBulletRoutine()
    {
      while(true)
        {
            // 1. Calculate the spawn position slightly off-screen to the right
            Vector3 spawnPosition = new Vector3(StaticInit.screenRightEdge.x + 1f, Random.Range(-5f,5f), 0);
            // 2. Spawn the enemy
            ShootEnemyBullet();
            // 3. Pause the loop 
            yield return new WaitForSeconds(BulletspawnRate);
        }
    }
}


