using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControler : MonoBehaviour
{
    [SerializeField] ParticleSystem movementParticle;

    [Range(0, 10)]
    [SerializeField] int occurAfterVelocity;

    [Range(0, 0.2f)]
    [SerializeField] float dustFormationPeriod;

    [SerializeField] Rigidbody playerRb;

    float counter;

    [SerializeField] ParticleSystem countTextParticle;

    private void Update()
    {
        counter += Time.deltaTime;

        if (Mathf .Abs(playerRb.velocity.x) > occurAfterVelocity)
        {

            if (counter > dustFormationPeriod)
            {
                movementParticle.Play();
                counter = 0;
            }



        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up3"))
        {  

            countTextParticle.Play();
           
        }


    }


}
