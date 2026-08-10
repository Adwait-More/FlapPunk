using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip collision;
    public AudioClip jump;
    public AudioClip point;
    public AudioClip fall;


    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCollisionSound()
    {
       AudioSource.PlayClipAtPoint(collision, Camera.main.transform.position);
        Invoke("PlayFallSound", 0.25f);
    }
    public void PlayJumpSound()
    {
       AudioSource.PlayClipAtPoint(jump, Camera.main.transform.position);
    }

  public void PlayPointSound()
    {
       AudioSource.PlayClipAtPoint(point, Camera.main.transform.position);
    }
    public void PlayFallSound()
        {
         AudioSource.PlayClipAtPoint(fall, Camera.main.transform.position);
    }
}
