using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData 
{
    public static GameData Data = new GameData();

    public int CurrentScore = 0;
    public int HighScore = 0;
//commit test 
//test dummy
    public void AddScore(int Score)
    {
        CurrentScore += Score;
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
        }
    }

    public void ResetScore()
    {
        CurrentScore = 0;
    }
}
