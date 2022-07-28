using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle compPaddle;
    public Text playerScoreText;
    public Text compScoreText;

    private int playerScore;
    private int compScore;

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
}
