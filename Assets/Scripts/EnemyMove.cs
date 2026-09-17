using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Keeps track of whether an enemy is currently standing in this spot
    public bool isOccupied = true;

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

        if (UnityEngine.Random.value <= 0.5f)
        {
            Move();
        }
    }

    
    public void Move()
    {


        switch (this.gameObject.name)
        {
            case "CheckDown":
                Debug.Log(this.gameObject.name+"CHECKDOWN");
                GetComponentInParent<Transform>().position += new Vector3(transform.position.x, transform.position.y-1f, transform.position.z);
                break;
            case "CheckLeft":
                Debug.Log(this.gameObject.name + "CHECKLEFT");
                GetComponentInParent<Transform>().position = new Vector3(transform.position.x-1f, transform.position.y, transform.position.z);
                break;
            case "CheckRight":
                Debug.Log(this.gameObject.name + "CHECKRIGHT");
                GetComponentInParent<Transform>().position = new Vector3(transform.position.x+1f, transform.position.y, transform.position.z);
                break;
            case "CheckUp":
                Debug.Log(this.gameObject.name + "CHECKUP");
                GetComponentInParent<Transform>().position = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
                break;
            
        }
    
}
}