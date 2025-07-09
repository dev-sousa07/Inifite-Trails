using UnityEngine;
using UnityEngine.SceneManagement;

public class Lata : MonoBehaviour
{
    public int pontos = 5; // Pontos que essa lata vale

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AdicionarPontos(pontos);
            }
        }
    }
}
