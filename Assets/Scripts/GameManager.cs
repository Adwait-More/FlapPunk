
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] AudioManager audioManager;
    [SerializeField] AnimationManager animationManager;
    [SerializeField]  PipeSpawnner spawnner;
    [SerializeField] UiManager uiManager;
    [SerializeField] Background background;
    [SerializeField] private GameObject Buttons;
    [SerializeField] GameObject Cam;
    [SerializeField] EnemySpawnner eSpawner; 
    
    private Transform CameraTransform;
    [SerializeField] Transform PlayerTransform;
    private void Start()
    {
        
        Application.targetFrameRate = 120;
} 


    public void NextLevel_delay()
    {
        Invoke("NextLevel", 0.5f);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next Level");
    }
    public void InvRestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Next Level");
    }
    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Previous Level");
    }

    public void GameOver()
    {
        animationManager.PlayCollisionAnimation();
        if (spawnner != null)
        {
            spawnner.DisablePipeMovement();
        }
        background.enabled = false;
        audioManager.PlayCollisionSound();
        
        Invoke("InvRestartLvl" , 0.25f);
    }
    public void GainPoint()
    {
        audioManager.PlayPointSound();
        uiManager.UpdateScore();
        
    }

    public void IsGoingUp()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        audioManager.PlayJumpSound();
        animationManager.PlayPlayerAnimation();

    }

    public void BoosterModeOn()
    {
        
         Buttons.SetActive(true);
         foreach (GameObject pipe in spawnner.pipeList) 
             pipe.SetActive(false);
        // Cam.transform.position=new Vector3(Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x-2.5f,0,-2);   
        PlayerTransform.position =  Vector3.MoveTowards(PlayerTransform.position, new Vector3(-1.5f,0,0),1f);
        //
        eSpawner.Spawn();
        
    }
    public void IsGoingDown(){
}
}
