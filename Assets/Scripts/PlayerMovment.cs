using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController Player;
    Vector3 moveDir;
    public float speed = 10.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(InputManager.Instance.Move.x, 0, InputManager.Instance.Move.y) * Time.deltaTime * speed;
        Player.Move(moveDir);

    }
}
