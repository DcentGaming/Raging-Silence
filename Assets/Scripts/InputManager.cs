using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;



    private PlayerInput PInput;
    public PlayerInput.MoveActions moveActions => PInput.Move;
    public PlayerInput.InteractActions interactActions => PInput.Interact;
    public Vector2 Move => moveActions.MoveVec.ReadValue<Vector2>();
    public bool interact => interactActions.Interact.ReadValue<bool>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PInput = new PlayerInput();
        PInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        Instance = this;
    }


}
