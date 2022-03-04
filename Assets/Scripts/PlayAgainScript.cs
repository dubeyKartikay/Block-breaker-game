using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameStatus gameStatus;
    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    public void PlayAgain()
    {
        
        gameStatus.resetScore();
        SceneManager.LoadScene(1);
    }
}
