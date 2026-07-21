using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    Transform t;
    
    

   public float StartingSpeed = 0f;
   public float CurrentSpeed;
   public float Decleration = 10f;
   int TouchCount = 0;
    bool GoingUp;
    bool GoingDown;
    private AudioManager audioManager;
    private GameManager gameManager;
    private UiManager uiManager;
    

    void Start()
    {
        Application.targetFrameRate = 120;
          
        
        t = GetComponent<Transform>();
        gameManager = FindAnyObjectByType<GameManager>();
        uiManager = FindAnyObjectByType<UiManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }


    void Update()
    {
        CurrentSpeed -= Decleration * Time.deltaTime;
        transform.position += Vector3.up * CurrentSpeed * Time.deltaTime;

        if (Input.touchCount > 0)
        {

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (TouchCount == 0)
                {
                    Time.timeScale = 1;
                    TouchCount++;
                }
                GoUp();

            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {


            Time.timeScale = 1;
            TouchCount++;

            GoUp();
        }


        void GoUp()
        {
          audioManager.PlayJumpSound();
            CurrentSpeed = StartingSpeed;
           
        }
        if(transform.position.y > 5f || transform.position.y < -5f)
    {
            gameManager.RestartLVl();
        }
    }
   

}



