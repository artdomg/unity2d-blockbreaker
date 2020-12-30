using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int scorePerBlockDestroyed = 25;

    [SerializeField] int currentScore = 0;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += scorePerBlockDestroyed;
    }
}
