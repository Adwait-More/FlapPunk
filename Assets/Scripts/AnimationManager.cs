using UnityEditor.Search;
using UnityEngine;

public class AnimationManager:MonoBehaviour
{
    
    [SerializeField] Animator thrustAnim;
    [SerializeField] Animator collidedAnim;
    public void PlayPlayerAnimation()
    {
            thrustAnim.SetTrigger("Flap");
            
    }

    public void PlayCollisionAnimation()
    {
      
            collidedAnim.SetTrigger("Collided");
       
    }
}
