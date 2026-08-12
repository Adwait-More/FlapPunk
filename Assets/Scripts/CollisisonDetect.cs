using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    
    public int score = 0;
 
    private GameManager gameManager;
    private StateMachine stateMachine;
    
   
    private void Start()
    {
        stateMachine=FindAnyObjectByType<StateMachine>();
        gameManager = FindAnyObjectByType<GameManager>();
       
    }


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
