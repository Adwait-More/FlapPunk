using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] StateMachine stateMachine;
    private int counter;
    
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if(collision.gameObject.CompareTag("Pipe")||collision.gameObject.CompareTag("Enemy"))
        {
            stateMachine.EndGame();
        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            if (StaticInit.score == 10)
            {
                stateMachine.BoosterModeOn();
                counter=1;
            }

            StaticInit.score++;
            
            gameManager.GainPoint();
            Debug.Log("Score: " + StaticInit.score);
            
        }
    }


}
