using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveErika : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(Vector3.right*2);
            //animator.SetBool("IsWalking", true);


            animator.SetBool("IsWalking", true);

            animator.SetBool("IsIdle", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsRunning", true);
            }
            else
            {
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsRunning", false);
            }




        }
        else
        {
            //animator.SetBool("IsRunning", false);
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsRunning", false);
        }
        

    }
}
