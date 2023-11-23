using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation()
    {
        if (animator != null)
        {
            animator.ResetTrigger("Trigger");
            
            // Trigger the animation
            animator.SetTrigger("Trigger"); // Replace with the actual trigger name in your Animator window
        }
    }





}
