using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}