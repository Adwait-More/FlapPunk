using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < StaticInit.screenLeftEdge.x)
        {
            if (StaticInit.score > 1)
            {
                StaticInit.score--;
            }
            else
            {
              StaticInit.gameManager.GameOver();
            }
        }
            
    }
}