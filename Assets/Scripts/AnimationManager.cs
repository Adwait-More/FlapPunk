using UnityEngine;

public class AnimationManager:MonoBehaviour
{
    
    public void PlayPlayerAnimation()
    {
        GameObject ThrustAnim = GameObject.Find("Thruster");
        if (ThrustAnim != null)
            {
            ThrustAnim.GetComponent<Animator>().SetTrigger("Flap");
            
            }
       
    }
}
