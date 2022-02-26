using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public int coinGrab;
    public int shieldHits;
    public int coinCount;
    private void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (shieldHits == 0)
        {

            if (collision.gameObject.CompareTag("Enemy"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            shieldHits--;
        }

        if (collision.gameObject.CompareTag("Coins"))
        {
            coinCount++;
        }
    }
}
