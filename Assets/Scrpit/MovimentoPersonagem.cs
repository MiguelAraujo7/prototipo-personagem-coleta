using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoPersonagem : MonoBehaviour
{
    public float velocidade = 5f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 movimento = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            movimento += Vector3.forward;

        if (Keyboard.current.sKey.isPressed)
            movimento += Vector3.back;

        if (Keyboard.current.aKey.isPressed)
            movimento += Vector3.left;

        if (Keyboard.current.dKey.isPressed)
            movimento += Vector3.right;

        controller.Move(movimento.normalized * velocidade * Time.deltaTime);
    }
}