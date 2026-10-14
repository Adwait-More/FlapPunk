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
}
