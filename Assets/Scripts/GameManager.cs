using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   public void RestartLVl()
    {
       Invoke("InvRestartLvl", 0.5f);
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
}
