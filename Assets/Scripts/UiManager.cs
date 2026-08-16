using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Jobs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private CollisisonDetect scoreCollisison;
    [SerializeField] TextMeshProUGUI scoreText;
    
    

    private void Start()
    {
        
        scoreCollisison.score++;
    }

    public void UpdateScore()
    {
       scoreText.text="Score:"+scoreCollisison.ToString();
        scoreCollisison.score++;
       
    }
    
}
