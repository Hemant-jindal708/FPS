using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;
    int myScore=0;
    [SerializeField] private Panalscore pl;

    void Update()
    {
        scoretext.text = myScore.ToString();
    }
    public void addscore(int score)
    {
        myScore=myScore+score;
    }
    public void gameover()
    {
        scoretext.text="GAME OVER";
    }
    public void Givescore(int x)
    {
        x=myScore;
    }
}