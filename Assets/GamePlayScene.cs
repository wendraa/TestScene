using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GamePlayScene : MonoBehaviour
{
    [SerializeField]
    private Text currentScore;
    [SerializeField]
    private Text highScore;

    private void Awake()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        StaticData.ResetScore();
        RefreshScore();
    }

    private void RefreshScore()
    {
        currentScore.text = StaticData.CurrentScore.ToString();
        highScore.text = StaticData.HighScore.ToString();
    }

    public void AddScore(int score)
    {
        StaticData.AddScore(score);

        RefreshScore();
    }

    public void GoToHomeScene()
    {
        Debug.Log("Go To Home Scene");
        SceneManager.LoadScene("Home");
    }

}
