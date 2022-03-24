using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public float invincibilityLength;
    private float invincibilityCounter;
  
    void Update()
    {
        if (invincibilityCounter > 0)
        {
            invincibilityCounter -= Time.deltaTime;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (invincibilityCounter <= 0)
        { if (collision.gameObject.CompareTag("Enemy"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if (collision.gameObject.CompareTag("invincible"))
            {
                invincibilityCounter = invincibilityLength;
            }


        }


    }
}
