using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Jobs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
     TextMeshProUGUI scoreText;
    int score;

 

    public void UpdateScore()
    {
       scoreText.text="Score:"+FindAnyObjectByType<CollisisonDetect>().score.ToString();
        score++;
       
    }
    
}
