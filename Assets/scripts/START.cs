using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class START : MonoBehaviour
{
    [SerializeField] private PlayerInput pl1;

    private Controls controls;
    [SerializeField] private GameObject gameOverPanel1 ,gl;
    [SerializeField] private Player pl;
    [SerializeField] private GameObject txt, txt2;
    [SerializeField] private pausegame plu;
    void Awake()
    {
        controls = new Controls();
        pl.enabled = false;
        pl1.enabled = false;
        txt2.SetActive(false);
        plu.enabled = false;
    }
    void Start()
    {
        gl.SetActive(false);
    }


    public void Begin()
    {
        gameOverPanel1.SetActive(false);
        pl.enabled = true;
        pl1.enabled = true;
        gl.SetActive(true);
        txt2.SetActive(true);
        plu.enabled = true ;
    }
    private void OnStart()
    {
        Begin();
        txt.SetActive(false);
    }
}