using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator ThrustAnim;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     

    // Update is called once per frame
   public void SetTrigger()
    {
       
        ThrustAnim.SetTrigger("Flap");
        
    }
}
