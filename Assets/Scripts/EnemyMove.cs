using UnityEngine;

public class NeighborSensor : MonoBehaviour
{
    // Keeps track of whether an enemy is currently standing in this spot
    public bool isOccupied { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log(collision.gameObject.name);
            isOccupied = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("OBJECT DIED");
            isOccupied = false;
        }
    }
}