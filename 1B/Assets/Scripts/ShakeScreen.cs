using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreen : MonoBehaviour
{

    [SerializeField] Animator shakeMe;

    public void ScreenShake()
    {
        int randomShake = Random.Range(0, 4);
        if (randomShake == 0)
        {
            shakeMe.SetTrigger("ShakeIt");
        }
        if (randomShake == 1)
        {
            shakeMe.SetTrigger("ShakeIt2");
        }
        if (randomShake == 2)
        {
            shakeMe.SetTrigger("ShakeIt3");
        }
        if (randomShake == 3)
        {
            shakeMe.SetTrigger("ShakeIt4");
        }
    }
    
}
