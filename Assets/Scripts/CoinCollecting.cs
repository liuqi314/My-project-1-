using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] float duration;
    [SerializeField] LeanTweenType easeType;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Move();


    }

    void Move()
    {
        LeanTween.moveX(gameObject, targetTransform.position.x, duration).setEase(easeType);




    }
}
