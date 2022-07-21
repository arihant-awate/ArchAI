using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveErika : MonoBehaviour
{
    [SerializeField]Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsWalking", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (animator.GetBool("IsRunning")==false)
                {
                    animator.SetBool("IsWalking", false);
                    animator.SetBool("IsRunning", true);
                }
            }
            else
            {
                animator.SetBool("IsWalking", true);

            }
            
            
                
            
           
        }
        else
        {
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", false);
            
        }
    }
}
