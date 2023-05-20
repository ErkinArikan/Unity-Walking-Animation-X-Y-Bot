using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;
    



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }



    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");

        bool fowardPress = Input.GetKey("w");

        bool runPressed = Input.GetKey("left shift");
        bool isRuning = animator.GetBool("isRuning");

        //if player presses w key
        if (!isWalking && fowardPress)
        {
            // then set the isWalking boolean to be true
            animator.SetBool("isWalking", true);
        }

        // if player is not pressing w key
        if (!fowardPress && isWalking)
        {
            // then set the isWalking boolean to be false   
            animator.SetBool("isWalking", false);
        }


        //if player is walking and not runing and presses left  shift 
        if (!isRuning && (runPressed && fowardPress))
        {
            // then set the isRuning boolean to be true
            animator.SetBool("isRuning", true);
        }

        //if player is stops walking and stops runing or stops walking 
        if (isRuning &&  (!fowardPress || !runPressed))
        {
            // then set the isRuning boolean to be false   
            animator.SetBool("isRuning", false);
        }




    }
}
