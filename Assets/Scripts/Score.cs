/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Score : MonoBehaviour
{
    [Header("Players :")]
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    [Header("Goal :")]
    [SerializeField] GameObject leftGoalWall;
    [SerializeField] GameObject rightGoalWall;

    [Header("Ball :")]
    [SerializeField] GameObject ball;

    [Header("Score :")]
    [SerializeField] TMP_Text player1Score;
    [SerializeField] TMP_Text player2Score;
    private int p1score = 0;
    private int p2score = 0;

    [Header("Game Over :")]
    [SerializeField] GameObject GameOverPannel;

    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        GameOverPannel.SetActive(false);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1" && ball != null)
        {
            p1score++;
            player1Score.text = p1score.ToString();
            Debug.Log("Player 1 Score: " + p1score);
        }
        if (collision.tag == "Player2" && ball != null)
        {
            p2score++;
            player2Score.text = p2score.ToString();
            Debug.Log("Player 2 Score: " + p2score);
        }
        if (collision.tag == "Ball" && leftGoalWall != null)
        {
            GameOverPannel.SetActive(true);
        }
        if (collision.tag == "Ball" && rightGoalWall != null)
        {
            GameOverPannel.SetActive(true);
        }
    }
}
*/

























using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [Header("Players :")]
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    [Header("Goal :")]
    [SerializeField] GameObject leftGoalWall;
    [SerializeField] GameObject rightGoalWall;

    [Header("Ball :")]
    [SerializeField] GameObject ball;
    private Vector3 ballStartPosition;

    [Header("Score :")]
    [SerializeField] TMP_Text player1Score;
    [SerializeField] TMP_Text player2Score;
    private int p1score = 0;
    private int p2score = 0;

    [Header("Game Over :")]
    [SerializeField] GameObject GameOverPanel;

    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        GameOverPanel.SetActive(false);
        ballStartPosition = ball.transform.position;
    }

    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1" && ball != null)
        {
            p1score++;
            player1Score.text = p1score.ToString();
            Debug.Log("Player 1 Score: " + p1score);
        }
        if (collision.tag == "Player2" && ball != null)
        {
            p2score++;
            player2Score.text = p2score.ToString();
            Debug.Log("Player 2 Score: " + p2score);
        }
        if (collision.tag == "Ball" && leftGoalWall != null)
        {
            GameOverPanel.SetActive(true);
        }
        if (collision.tag == "Ball" && rightGoalWall != null)
        {
            GameOverPanel.SetActive(true);
        }
    }
  

    private void GameOver()
    {
        Time.timeScale = 0f; // Pause the game
        GameOverPanel.SetActive(true);
    }

    public void ResetGame()
    {
        Time.timeScale = 1f; // Resume the game
        p1score = 0;
        p2score = 0;
        player1Score.text = "0";
        player2Score.text = "0";
        GameOverPanel.SetActive(false);

        if (ball != null)
        {
            ball.transform.position = ballStartPosition;
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}


































































/* private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.CompareTag("Player1") && ball != null)
       {
           p1score++;
           player1Score.text = p1score.ToString();
           Debug.Log("Player 1 Score: " + p1score);
       }
       if (collision.CompareTag("Player2") && ball != null)
       {
           p2score++;
           player2Score.text = p2score.ToString();
           Debug.Log("Player 2 Score: " + p2score);
       }
       if (collision.CompareTag("Ball") && leftGoalWall != null)
       {
           GameOver();
       }
       if (collision.CompareTag("Ball") && rightGoalWall != null)
       {
           GameOver();
       }
   }*/