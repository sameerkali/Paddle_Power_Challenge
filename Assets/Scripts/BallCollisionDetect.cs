using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BallCollisionDetect : MonoBehaviour
    
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject p1Win;
    [SerializeField] private GameObject p2Win;

    [SerializeField]  private TMP_Text p1ScoreText;
    [SerializeField]  private TMP_Text p2ScoreText;
    int p1score = 0;
    int p2score = 0;
    private void Start()
    {
        GameOverScreen.active = false;
        p1Win.active = false;
        p2Win.active = false;
    }

    private void Pause()
    {
        Time.timeScale = 0;   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.transform.tag == "player1")
        { 
            Debug.Log("player 01");
        }
        if (collision.transform.tag == "player2")
        {
            Debug.Log("player 02");
        }
        if (collision.transform.tag == "leftGoal")
        {
            p2score += 1;
            //Debug.Log("p2 score a goal");
            p2ScoreText.text = p2score.ToString();
            if (p2score == 3)
            {
                GameOverScreen.active = true;
                p1Win.active = true;
                Pause();
            }
        }
        if (collision.transform.tag == "rightGoal")
        {
            p1score += 1;
            //Debug.Log("p1 score a goal");
            p1ScoreText.text = p1score.ToString();
            if(p1score == 3)
            {
                GameOverScreen.active = true;
                p2Win.active = true;
                Pause();
            }
        }
    }
}
