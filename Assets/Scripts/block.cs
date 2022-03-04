using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class block : MonoBehaviour
{
    [SerializeField] AudioClip blockDestroyedSFX;
    [SerializeField] GameStatus gameStatus;

    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameStatus.givePoints();
        if (transform.parent.childCount == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(blockDestroyedSFX, transform.position);
    }
}
