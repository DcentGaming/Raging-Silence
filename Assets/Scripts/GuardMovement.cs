using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    public CharacterController Guard;
    Vector3 moveDir;
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(InputManager.Instance.Move.x, 0, InputManager.Instance.Move.y) * Time.deltaTime * speed;
        Guard.Move(moveDir);
    }
}
