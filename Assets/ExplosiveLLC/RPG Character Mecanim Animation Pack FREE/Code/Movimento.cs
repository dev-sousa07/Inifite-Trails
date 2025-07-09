using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class RunnerController : MonoBehaviour
{
    public float velocidade = 10f;
    public float velocidadeLateral = 5f;
    public float gravidade = -9.81f;

    private CharacterController controller;
    private Vector3 velocidadeVertical;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimento automático para frente (Z)
        Vector3 movimento = transform.forward * velocidade;

        // Movimento lateral com input
        float horizontal = Input.GetAxis("Horizontal"); // A/D ou ← →
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

