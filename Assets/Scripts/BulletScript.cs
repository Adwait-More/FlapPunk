
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float  bulletSpeed;
   public  static Vector3 respawnPos;
    void Awake()
    {
        respawnPos = Camera.main.ViewportToWorldPoint(new Vector3(1f, 0.5f, 0));
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > respawnPos.x)
        {
            GameObject.Destroy(this.gameObject);
        }
        transform.Translate(Vector3.right * (bulletSpeed * Time.deltaTime));
    }
}
