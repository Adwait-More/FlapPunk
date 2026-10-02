using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public static StateMachine State_Machine;
    public GameState currentState;
    private GameManager gameManager;
    

    void Start()
    { 
        gameManager =FindObjectOfType<GameManager>();
        currentState = GameState.GetReady;
        Time.timeScale = 0f;
    }

    public void BoosterModeOn()
    {
        currentState = GameState.Booster;
        gameManager.BoosterModeOn();
        
    }
    
   public void StartGame()
    {
        Time.timeScale = 1f;
        currentState=GameState.Playing;
    }

    public void EndGame()
    {
        gameManager.GameOver();
         currentState=GameState.GameOver;
    }

    public void SInvasionModeOn()
    {
        currentState = GameState.Invading;
        gameManager.InvasionModeOn();
    }
}
