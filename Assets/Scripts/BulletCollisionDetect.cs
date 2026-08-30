using UnityEngine;

public class BulletCollisionDetect : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D colliderInfo)
    {
      Debug.Log(colliderInfo.gameObject.name);
        if (colliderInfo.CompareTag("Enemy"))
        {
            Destroy(colliderInfo.gameObject);
           GameObject.Destroy(this.gameObject);
        }
    }
}
