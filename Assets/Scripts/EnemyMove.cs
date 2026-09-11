using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Range(0f,1f)]
    [SerializeField] float switchChance = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<BoxCollider2D>().offset = new Vector2(GetComponent<BoxCollider2D>().offset.x,GetComponent<BoxCollider2D>().offset.y);
  
         
    }

    public void OnCollisionEnter2D
    {
        Debug.Log("Switch Script");
        if (collision.gameObject.tag == "Enemy")
        {
            if (Random.value <= switchChance)
            {
                collision.gameObject.GetComponent<EnemyMove>().SwitchScript();
            }
        }
    }
    
    public void SwitchScript()
    {
        Debug.Log("Switch Script");
          
    }
}


