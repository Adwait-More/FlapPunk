using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    
    public int score = 0;
 
    [SerializeField] GameManager gameManager;
    [SerializeField] StateMachine stateMachine;
    private int counter = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
          
            Debug.Log("Game Over");
stateMachine.EndGame();


        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            if (score == 10)
            {
                stateMachine.BoosterModeOn();
                counter=1;
            }
            score++;
            gameManager.GainPoint();
            Debug.Log("Score: " + score);
            
        }
    }


}
