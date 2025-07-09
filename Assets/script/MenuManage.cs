using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcao;

    public void Jogar()
    {
        StartCoroutine(CarregarCenaDepoisDeEspera());
    }

    IEnumerator CarregarCenaDepoisDeEspera()
    {
        // Aqui você pode tocar um som, mostrar uma animação ou tela de loading
        yield return new WaitForSeconds(2f); // Espera 10 segundos
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirOpcao()
    {
        painelMenuInicial.SetActive(false);
        painelOpcao.SetActive(true);
    }

    public void FecharOpcao()
    {
        painelMenuInicial.SetActive(true);
        painelOpcao.SetActive(false);
    }

    public void Sair()
    {
        Debug.Log("Saindo do Jogo");
        Application.Quit();
    }
}
