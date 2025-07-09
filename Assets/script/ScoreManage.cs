using UnityEngine;
using TMPro; // Importante: usar TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText; // Alterado para TextMeshProUGUI

    void Start()
    {
        score = 0;
        AtualizarTexto();
    }

    public void AdicionarPontos(int valor)
    {
        score += valor;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        scoreText.text = "Score: " + score;
    }
}
