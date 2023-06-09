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
        Debug.Log("I am start");

    }

    void Update()
    {
        Debug.Log("I am working ");
    }
    private void GameOver()
    {
        Time.timeScale = 0f;
        GameOverPanel.SetActive(true);
    }

    public void ResetGame()
    {
        Time.timeScale = 1f;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "player1" && ball != null)
        {
            p1score++;
            player1Score.text = p1score.ToString();
            Debug.Log("Player 1 Score: " + p1score);
        }

        /*if (collision.collider.tag == "Player2" && ball != null)
        {
            p2score++;
            player2Score.text = p2score.ToString();
            Debug.Log("Player 2 Score: " + p2score);
        }
        if (collision.collider.tag == "leftgole")
        {
            Debug.Log("colide");

            GameOverPanel.SetActive(true);
        }
        if (collision.collider.tag == "Ball" && rightGoalWall != null)
        {
            Debug.Log("colide galat chez");
            GameOverPanel.SetActive(true);
        }*/
    }
}




/*
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

    void Start()
    {
        GameOverPanel.SetActive(false);
        ballStartPosition = ball.transform.position;
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player1" && ball != null)
        {
            p1score++;
            Debug.Log("Player 1 Score: " + p1score);
            player1Score.text = p1score.ToString();
        }

        if (collision.collider.tag == "player2" && ball != null)
        {
            p2score++;
            Debug.Log("Player 2 Score: " + p2score);
            player2Score.text = p2score.ToString();
        }

        if (collision.collider.tag == "leftGoal")
        {
            Debug.Log("Collision with left goal");
            GameOver();
        }

        if (collision.collider.tag == "rightGoal")
        {
            Debug.Log("Collision with right goal");
            GameOver();
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
}*/
