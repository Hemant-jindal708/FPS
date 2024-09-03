using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausegame : MonoBehaviour
{
    private bool Check = false ;
    [SerializeField] private GameObject gl ,gl1;
    void Awake()
    {
        Check = false;
        gl.SetActive(false);
        gl1.SetActive(true);
        Time.timeScale = 1;
    }
    void Update()
    {
        // gl1 is pause button
        if (Check == true)
        {
            Time.timeScale = 0;
            gl1.SetActive(false);
            gl.SetActive(true);
        }
        else if (Check == false )
        {
            gl1.SetActive(true);
            gl.SetActive(false);
            Time.timeScale = 1;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Check == true)
            {
                Check = false;
            }
            else if(Check == false)
            {
                Check = true;
            }
            else if (gl.activeInHierarchy == false)
            {
                Application.Quit();
            }
        }
    }
    public void Click()
    {
        if (Check == false)
        {
            Check = true ;
        }
        else if (Check == true )
        {
            Check = false ;
        }
    }
    // public void OnPause()
    // {
    //     if (Check == false)
    //     {
    //         Check = true ;
    //     }
    //     else if (Check == true )
    //     {
    //         Check = false ;
    //     }
    // }
}
