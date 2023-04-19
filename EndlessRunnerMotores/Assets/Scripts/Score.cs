using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scoreNumber;
    public float scoreAdd;

    void Start()
    {
        scoreNumber = 0f;
    }

    void Update()
    {
        scoreText.text = "Score: " + (int)scoreNumber;
        scoreNumber += scoreAdd * Time.deltaTime;
    }

    public void SumarPuntos(int puntos)
    {
        scoreNumber += puntos;
    }
}