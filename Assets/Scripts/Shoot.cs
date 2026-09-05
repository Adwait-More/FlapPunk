using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 spawnPos;
   public void ShootBullet()
   {
       StaticInit.AudioManager.PlayShootSound();
    spawnPos = new Vector3(transform.position.x+0.2f, transform.position.y, transform.position.z);   
       GameObject bullet= Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
       bullet.SetActive(true);
    }
}
