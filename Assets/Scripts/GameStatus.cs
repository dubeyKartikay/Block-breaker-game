using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStatus : MonoBehaviour
{
    [SerializeField] float gameSpeed = 1f;
    [SerializeField] int currentScore = 0;
    [SerializeField] int pointPerBlock = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    private void Awake()
    {
        int gameStatusObjectCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusObjectCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
            
    }
    void Update()
    {
        Time.timeScale = gameSpeed;

    }

    public void givePoints()
    {
        currentScore += pointPerBlock;
        scoreText.SetText(currentScore.ToString());

    }

    public void resetScore()
    {
        scoreText.SetText("0");
        currentScore = 0;
    }

}
