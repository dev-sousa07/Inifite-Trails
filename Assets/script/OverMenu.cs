using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OverMenu : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject sair;
    [SerializeField] private TextMeshProUGUI scoreFinalText; // Campo para o texto do score

    void Start()
    {
        int scoreFinal = PlayerPrefs.GetInt("ScoreFinal", 0);
        if (scoreFinalText != null)
        {
            scoreFinalText.text = "Score: " + scoreFinal;
        }
    }

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Sair()
    {
        Debug.Log("Saindo do Jogo");
        Application.Quit();
    }
}
