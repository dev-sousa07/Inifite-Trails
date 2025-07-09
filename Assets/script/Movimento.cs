using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class Movimento : MonoBehaviour
{
    public float velocidade = 2f;
    public float velocidadeLateral = 5f;
    public float gravidade = -9.81f;


    private CharacterController controller;
    private Vector3 velocidadeVertical = Vector3.zero;

    private float tempoDeInicio;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        tempoDeInicio = Time.time; // Marca o início do jogo

    }

    void Update()
    {
        // Movimento automático para frente
        Vector3 movimento = transform.forward * velocidade;

        // Movimento lateral
        float horizontal = Input.GetAxis("Horizontal");
        movimento += transform.right * horizontal * velocidadeLateral;

        // Gravidade
        if (controller.isGrounded)
            velocidadeVertical.y = -1f;
        else
            velocidadeVertical.y += gravidade * Time.deltaTime;

        movimento += velocidadeVertical;

        controller.Move(movimento * Time.deltaTime);


    }
}
