using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public PlayerMovement player1;
    public PlayerMovement2 player2;
    public Rigidbody2D ball;
    public Collider2D bola;
    public GameObject text2;
    private Score score;
    public GameObject text1;
    public Text DebugText;


    public int maxScore;
    private bool isDebugShown = false;
    private float ballMass;
    private Vector2 ballVelocity;
    private float ballSpeed;
    private Vector2 ballMomentum;
    private float ballFriction;
    private float impulseplayer1X;
    private float impulseplayer2X;
    private float impulseplayer1Y;
    private float impulseplayer2Y;
    private string debugText;


    // Start is called before the first frame update
    void Start()
    {
        //DebugText = GetComponent<Text>();
        //ball = GetComponent<Rigidbody2D>();
        //bola = GetComponent<Collider2D>();
        //player1 = GetComponent<PlayerMovement>();
        //player2 = GetComponent<PlayerMovement2>();
        text1.SetActive(false);
        text2.SetActive(false);

        //GameObject.Find("DebugText").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isDebugShown);


        //Debug.Log(ScoreLimiter(Score.Player1Score, Score.Player2Score, maxScore));
        ScoreLimiter(Score.Player1Score, Score.Player2Score, maxScore);
        if (isDebugShown)
        {
            ballMass = ball.mass;
            ballVelocity = ball.velocity;
            ballSpeed = ball.velocity.magnitude;
            ballMomentum = ballMass * ballVelocity;
            ballFriction = bola.friction;
            impulseplayer1X = player1.LastContactPoint().normalImpulse;
            impulseplayer1Y = player1.LastContactPoint().tangentImpulse;
            impulseplayer2X = player2.LastContactPoint().normalImpulse;
            impulseplayer2Y = player2.LastContactPoint().tangentImpulse;

            //Debug.Log(impulseplayer1X);
            //Debug.Log(impulseplayer1Y);
            //Debug.Log(impulseplayer2X);
            //Debug.Log(impulseplayer2Y);


            debugText =
                "Ball mass = " + ballMass + "\n" +
                "Ball velocity = " + ballVelocity + "\n" +
                "Ball speed = " + ballSpeed + "\n" +
                "Ball momentum = " + ballMomentum + "\n" +
                "Ball friction = " + ballFriction + "\n" +
                "Last impulse from player 1 = (" + impulseplayer1X + ", " + impulseplayer1Y + ")\n" +
                "Last impulse from player 2 = (" + impulseplayer2X + ", " + impulseplayer2Y + ")\n";
            //Debug.Log("Mass: "+ballMass);
            //Debug.Log("Velo: "+ballVelocity);
            //Debug.Log("Speed: " +ballSpeed);
            //Debug.Log("Momentum: " + ballMomentum);
            //Debug.Log("Friction: " +ballFriction);

            DebugText.text = debugText;
        }
        else
        {
            DebugText.text = null;
        }
    }

    private void ScoreLimiter(int score1, int score2, int max)
    {
        if (score1 == max || score1 > max)
        {
            Time.timeScale = 0;
            text1.SetActive(true);
            //Debug.Log("Jalan ni if score1 == max");
            
        }
        else if(score2 == max || score2 > max)
        {
            Time.timeScale = 0;
            text2.SetActive(true);
            //Debug.Log("Jalan ni else if score2 == max");

        }
    }

    public void PopUpHider()
    {
        text1.SetActive(false);
        text2.SetActive(false);
    }

    public void ToggleDebug()
    {
        if (isDebugShown)
        {
            isDebugShown = false;
        }
        else 
        {
            isDebugShown = true;
        }
    }

}
