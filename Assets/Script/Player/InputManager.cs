using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region singleton
    private static InputManager instance;
    public static InputManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<InputManager>();
            }
            return instance;
        }
    }
    #endregion

    public bool isPresForw;
    public bool isPresDown;
    public bool isPresRight;
    public bool isPresLeft;
    public void MoveInput()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            isPresForw = true;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            isPresDown = true;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            isPresRight = true;
        }
        else if(Input.GetKeyDown(KeyCode.A)) 
        {
            isPresLeft = true;
        }
    }

}
