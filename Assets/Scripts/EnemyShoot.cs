using System.Collections;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    // Update is called once per frame
    public Transform PlayerPos;
    [SerializeField] private float bulletSpeed;
    public static Vector3 respawnPos;
    public float BulletspawnRate=0;
    public float BulletDespawnRate;
   
    void Start()
    {
        Vector3 spawnPosition = new Vector3(StaticInit.screenRightEdge.x + 1f, Random.Range(-5f,5f), 0);
        StartCoroutine(SpawnEnemyBulletRoutine());
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
        Destroy(bullet, BulletDespawnRate);
        bullet.SetActive(true);
    }
    private IEnumerator SpawnEnemyBulletRoutine()
    {
      while(true)
        {
            // 2. Spawn the enemy
            ShootEnemyBullet();
            // 3. Pause the loop 
            yield return new WaitForSeconds(BulletspawnRate+Random.Range(3,5f));
        }
    }

   
}


