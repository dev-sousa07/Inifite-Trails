using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importa para usar SceneManager

public class Vida : MonoBehaviour
{
    public string OverMenu; // Nome da cena do Game Over
    public Movimento playermov;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            if (playermov != null)
            {
                playermov.enabled = false; // Desabilita o script de movimento
            }

            // ? Salvar o score antes de trocar de cena
            PlayerPrefs.SetInt("ScoreFinal", ScoreManager.score);
            PlayerPrefs.Save(); // (opcional, mas garante o salvamento)

            Time.timeScale = 1f; // Garante que o tempo esteja normal antes de trocar de cena

            SceneManager.LoadScene(OverMenu); // Carrega a cena de Game Over
        }
    }
}
