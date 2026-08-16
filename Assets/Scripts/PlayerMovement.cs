using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
   public float startingSpeed = 0f;
   public float currentSpeed;
   public float decleration = 10f;
   bool hasTouched = false;
    bool goingUp;
    bool goingDown;
    bool IsFlappy = true;
    private GameManager gameManager;
    private StateMachine stateMachine;
    
 

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        stateMachine=FindAnyObjectByType<StateMachine>();
    }


    void Update()
    {
        if (IsFlappy)
        {
            if (stateMachine.currentState == GameState.GameOver)
            {
                return;
            }

            currentSpeed -= decleration * Time.deltaTime;
            transform.position += Vector3.up * currentSpeed * Time.deltaTime;

            if (Input.touchCount > 0)
            {

                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if (hasTouched == false)
                    {
                        stateMachine.StartGame();
                        hasTouched = true;
                    }

                    GoUp();

                }

            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (hasTouched == false)
                {
                    Time.timeScale = 1;
                    hasTouched = true;
                }

                GoUp();
            }



            if (transform.position.y > 5f || transform.position.y < -5f)
            {
                gameManager.RestartLVl();
            }


            public void GoUp()
            {
                gameManager.IsGoingUp();
                currentSpeed = startingSpeed;

            }
        

    }
}



