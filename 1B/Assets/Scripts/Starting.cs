using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    bool isActive = true;




    private void Update()
    {
        if (isActive == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            isActive = false;
        }

        if (isActive == false)
        {
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
        }
    }


}
