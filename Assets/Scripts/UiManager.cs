using TMPro;
using UnityEngine;


public class UiManager : MonoBehaviour
{
    [SerializeField] CollisisonDetect scoreCollisison;
    [SerializeField] TextMeshProUGUI scoreText;
    
    

    

    public void UpdateScore()
    {
        scoreText.text = "SCORE:" + scoreCollisison.score.ToString();
    }
    
}
