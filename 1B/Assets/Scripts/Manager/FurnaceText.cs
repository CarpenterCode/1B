using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceText : MonoBehaviour
{
    GameObject gameMngr;

    private void Start()
    {
        gameMngr = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void Update()
    {
        if (gameMngr.GetComponent<NextLevel>().currentLevel > 1)
        {
            this.gameObject.SetActive(false);
        }
    }
}
