using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text maxScoreText;

    public float valorScore;
    public float maxScore;




    private void Start()
    {
        maxScore = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxScoreText.text =  maxScore.ToString("0.0");
    }

    void Update()
    {
        valorScore += Time.deltaTime;

        scoreText.text = valorScore.ToString("0.00");

        if (maxScore < valorScore)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", valorScore);

            maxScoreText.text = valorScore.ToString("0.0");
        }
    }


    public void AddScore( float scoreObjectValue )
    {

        valorScore += scoreObjectValue;

    }



}
