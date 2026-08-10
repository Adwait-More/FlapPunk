using UnityEngine;

public class AnimationManager:MonoBehaviour
{
    
    public Animator thrustAnim;
    public Animator collidedAnim;
    public void PlayPlayerAnimation()
    {
            thrustAnim.SetTrigger("Flap");
            
    }

    public void PlayCollisionAnimation()
    {
      
            collidedAnim.SetTrigger("Collided");
       
    }
}
