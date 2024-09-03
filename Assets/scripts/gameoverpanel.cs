using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Runtime.CompilerServices;

public class Gameoverpanel : MonoBehaviour
{
    
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject gameOverPanel1;
    [SerializeField] private GameObject txt ,gl;
    [SerializeField] private PlayerInput pl1,pl2;
    [SerializeField] private Player pl;
    [SerializeField] private pausegame pl12;

    void Start()
    {
        gameOverPanel.SetActive(false);
        gameOverPanel1.SetActive(false);
    }
    public void GameOver()
    {
        pl12.enabled=false;
        txt.SetActive(false);
        gameOverPanel.SetActive(true);
        pl1.enabled=false;
        pl2.enabled=false;
        gl.SetActive(false);
        pl.enabled=false;
        pl1.DeactivateInput();
        pl2.DeactivateInput();
    }
    public void Win()
    {
        pl12.enabled=false;
        gameOverPanel1.SetActive(true);
        pl2.enabled = false;
        pl.enabled=false;
        pl2.DeactivateInput();
        pl1.DeactivateInput();
        gl.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
