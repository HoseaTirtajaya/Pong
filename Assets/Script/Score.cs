using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreBoard;
    public GameObject ball;

    public static int Player1Score = 0;
    public static int Player2Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        //print(Player1Score + " , " + Player2Score);

        ScoreBoard.text = Player1Score.ToString() + " - " + Player2Score.ToString();
    }

    public void ResetScore()
    {
        Time.timeScale = 1;
        Player1Score = 0;
        Player2Score = 0;
    }
}
