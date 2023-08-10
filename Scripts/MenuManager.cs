using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject GameMenu;
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameMenu.gameObject.SetActive(!GameMenu.gameObject.activeSelf);

        }
    }
}
