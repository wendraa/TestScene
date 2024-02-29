using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeScene : MonoBehaviour
{
    [SerializeField]
    private Text highScore;

    private void Awake()
    {
        highScore.text = StaticData.HighScore.ToString();
    }

    public void GoToPlayScene()
    {
        Debug.Log ("Go To Play Scene");
        SceneManager.LoadScene("GamePlay");
    }
}
