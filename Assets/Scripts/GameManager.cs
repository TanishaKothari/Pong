using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public GameObject gBall;
    public Paddle playerPaddle;
    public Paddle compPaddle;
    public Text playerScoreText;
    public Text compScoreText;
    public Text gameOverText;
    public Button replayButton;

    private int playerScore;
    private int compScore;

    private void Update()
    {
        GameOver();
    }
    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void CompScores()
    {
        compScore++;
        this.compScoreText.text = compScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.compPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    private void GameOver()
    {
        if (playerScore == 11)
        {
            gameOverText.enabled = true;
            gameOverText.text = "Game Over\nYou Win";
            gBall.SetActive(false);
            replayButton.gameObject.SetActive(true);
        }
        else if (compScore == 11)
        {
            gameOverText.enabled = true;
            gameOverText.text = "Game Over\nComputer Wins\nBetter Luck Next Time";
            gBall.SetActive(false);
            replayButton.gameObject.SetActive(true);
        }
    }

    public void Restart()
    {
        gameOverText.enabled = false;
        gBall.SetActive(true);
        playerScore = compScore = 0;
        playerScoreText.text = compScoreText.text = "0";
        ResetRound();
        replayButton.gameObject.SetActive(false);
    }
}