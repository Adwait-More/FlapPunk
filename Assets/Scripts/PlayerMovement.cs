
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float startingSpeed = 0f;
    public float currentSpeed;
    public float decleration = 10f;
    public float MoveSpeed=5;
    bool _hasTouched = false;
    [SerializeField]private GameManager gameManager;
    [SerializeField]private StateMachine stateMachine;
    private Vector3 targetPos=new Vector3(0f,0f,0f);

    void Start()
    {
        stateMachine.StartGame();
        targetPos=Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, 0f))+new Vector3(0.5f,0f,0f);
        targetPos=new Vector3(targetPos.x,0f,0f);
    }
    void Update()
    {
        
        if (stateMachine.currentState == GameState.Playing)
        {
            transform.position += Vector3.up * currentSpeed * Time.deltaTime;
            //Normal flappy bird
            if (stateMachine.currentState == GameState.GameOver)
            {
                return;
            }
            //Gravity and movement logic
            currentSpeed -= decleration * Time.deltaTime;
            
            //Cecks the total number of touches on the screen at the same time 
            if (Input.touchCount > 0)//We use this to prevent the next if statement from crashing due to an index out of range execption
            {
            //Checks for the first finger to touch the screen and if the finger jsut made contact with the screen
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    //logic for the first touch
                    if (_hasTouched == false)
                    {
                        stateMachine.StartGame();
                        _hasTouched = true;
                    }
                    Jump(); 
                }
            }
            //Check if player is OutOfBounds
            if (transform.position.y > 5f || transform.position.y < -5f)
            {
                stateMachine.EndGame();
            }
        }
        else if(stateMachine.currentState == GameState.Booster)
        {
            if (Vector3.Distance(transform.position, targetPos) >= 0.1f  )
            {
             transform.position = Vector3.MoveTowards(transform.position, targetPos, 2f * Time.deltaTime);
           }
            else 
            {
                transform.position += Vector3.up * currentSpeed * Time.deltaTime;
                stateMachine.SInvasionModeOn();
            }

            if(Input.touchCount ==0)
            currentSpeed -= currentSpeed;
        }
        else if (stateMachine.currentState == GameState.Invading)
        {
            transform.position += Vector3.up * currentSpeed * Time.deltaTime;
            if (transform.position.y > StaticInit.screenTopEdge.y)
            {
                currentSpeed = -MoveSpeed;
               
            }
            if (transform.position.y < StaticInit.screenBottomEdge.y)
            {
                currentSpeed = MoveSpeed;
                
            } 
        }
      
    }
    
    public void Jump()
    {
        gameManager.IsGoingUp();
        
        currentSpeed = startingSpeed;

    }
    public void Go()
    {
        transform.position += Vector3.up * currentSpeed * Time.deltaTime;
    }
    

    public void GO_UP()
    {
        currentSpeed = MoveSpeed;

    }

    public void Set0()
    {
        currentSpeed = 0;
    }

    public void GO_DOWN()
    {
        currentSpeed = -MoveSpeed;
    }
}





