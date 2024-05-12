using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool isPanel;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        //CheckPointer();
    }

    private void CheckPointer()
    {
        if (isPanel) { 
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (!isPanel)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
