using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    
    public int score = 0;
 
    [SerializeField] GameManager gameManager;
    [SerializeField] StateMachine stateMachine;
    
   
    


    private void OnTriggerEnter2D(Collider2D collision)


    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
           
            gameManager.RestartLVl();
            gameManager.GameOver();
            Debug.Log("Game Over");
stateMachine.EndGame();


        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            score++;
            gameManager.GainPoint();
            Debug.Log("Score: " + score);
            
        }
    }


}
