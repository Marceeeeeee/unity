using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage (float amount) {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
        
    }

    public void GameOver (float amount) {
        health -= amount;
        if (health <= 0f)
        {
            GameOverCiao();
        }
        
    }

    void Die(){
        Destroy(gameObject);
    }

    void GameOverCiao(){
    SceneManager.LoadScene(2);
    }

}
