using System.Timers;
using UnityEngine;

public class LookoutMovement : MonoBehaviour
{
    public CharacterController Lookout;
    public float RotSpeed = 40;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Lookout.transform.Rotate(Vector3.up * (RotSpeed * Time.deltaTime));
    }


}
