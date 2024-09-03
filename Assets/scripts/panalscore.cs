using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Panalscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext1;
    int panelscore;
    [SerializeField] private TextMeshProUGUI txt;
    void Update()
    {
        // Assign the text value from txt to scoretext1
        scoretext1.text = String.Concat("Score: ", txt.text);
    }


}
