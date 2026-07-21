using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip Collision;
    public AudioClip Jump;
    public AudioClip Point;
    public AudioClip Fall;


    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCollisionSound()
    {
       AudioSource.PlayClipAtPoint(Collision, Camera.main.transform.position);
        Invoke("PlayFallSound", 0.25f);
    }
    public void PlayJumpSound()
    {
       AudioSource.PlayClipAtPoint(Jump, Camera.main.transform.position);
    }

  public void PlayPointSound()
    {
       AudioSource.PlayClipAtPoint(Point, Camera.main.transform.position);
    }
    public void PlayFallSound()
        {
         AudioSource.PlayClipAtPoint(Fall, Camera.main.transform.position);
    }
}
