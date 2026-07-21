using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    public int Score = 0;
    public Animator MyAnim;
    private GameManager gameManager;
    private UiManager uiManager;
    private AudioManager audioManager;
    private void Start()
    {
        MyAnim = FindObjectOfType<Animator>();
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UiManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)


    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            audioManager.PlayCollisionSound();
            var _Pipes = FindObjectsOfType<PipeMovement>();
            foreach(var pipe in _Pipes)
            {
                pipe.DisableMovement();
            }
            gameManager.RestartLVl();
            Debug.Log("Game Over");
            MyAnim.SetTrigger("Collided");




        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            Score++;
            audioManager.PlayPointSound();
            Debug.Log("Score: " + Score);
           
            uiManager.UpdateScore();
        }
    }


}
