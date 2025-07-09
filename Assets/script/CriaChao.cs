using System.Collections;
using UnityEngine;

public class CriaChao : MonoBehaviour
{

    [SerializeField]
    private GameObject chao, go;
    [SerializeField]
    private float tamanhoXZ;
    [SerializeField]
    private Vector3 posUltima;


    void Start()
    {
        posUltima = chao.transform.position;
        tamanhoXZ = chao.transform.localScale.x;

        StartCoroutine(CriaChaoInGame());
    }


    void Update()
    {  

    }

    void CriaX()
    {
        Vector3 tempPos = posUltima;
        tempPos.x += (tamanhoXZ * 22);
        posUltima = tempPos;
        Instantiate(chao, tempPos, Quaternion.identity);
    }

    IEnumerator CriaChaoInGame() 
    {
        int rand = Random.Range(0, 1);
        while (rand <= 1)
        {
            yield return new WaitForSeconds(1);
            CriaX();
        }
    }
}
