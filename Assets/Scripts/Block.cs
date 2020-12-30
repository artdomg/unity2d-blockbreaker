using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    Level level;
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        gameStatus = FindObjectOfType<GameStatus>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 position = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(breakSound, position);
        level.BlockDestroyed();
        gameStatus.AddToScore();
        Destroy(gameObject);
    }
}
