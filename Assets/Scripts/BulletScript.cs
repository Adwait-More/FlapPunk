
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float  bulletSpeed;
    public StateMachine stateMachine;
   public  static Vector3 respawnPos;
   public Vector3 BulltetFinalPos;
   public GameObject Player;
   public bool ISEnemyBullet;
   public float EnemyBulletSpeed;
   public float waitTime;
   
    void Awake()
    {
        respawnPos = Camera.main.ViewportToWorldPoint(new Vector3(1f, 0.5f, 0));
        StartCoroutine(ClacPos());
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!ISEnemyBullet)
        {
            if (transform.position.x > respawnPos.x)
            {
                GameObject.Destroy(this.gameObject);
            }
                        
            transform.Translate(Vector3.right * (bulletSpeed * Time.deltaTime));
        }
        else
        {
            if (transform.position.x < -respawnPos.x)
            {
                GameObject.Destroy(this.gameObject);
            }
           transform.position=Vector3.MoveTowards(transform.position, BulltetFinalPos, EnemyBulletSpeed * Time.deltaTime);
            
        }
    }
    void OnTriggerEnter2D(Collider2D colliderInfo)
    { 
       
        if (colliderInfo.CompareTag("Enemy")&&!ISEnemyBullet)
        {
            GameObject.Destroy(this.gameObject);
           StaticInit.gameManager.KillEnemy(colliderInfo);
        }
        else if (colliderInfo.CompareTag("Player")&&ISEnemyBullet)
        {
            stateMachine.EndGame();
        }
    }

    private IEnumerator ClacPos()
    {
        while (true)
        {
            BulltetFinalPos=Player.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
    


} 

