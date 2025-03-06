using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class GuardMovement : MonoBehaviour
{
    public Transform Post_1;
    public Transform Post_2;
    private NavMeshAgent agent;
    public Angle<float> FOV;
    public Transform _player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            agent = GetComponent<NavMeshAgent>();
            agent.destination = Post_1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Post_1.position) <= 0.5f) agent.destination = Post_2.position;
        if (Vector3.Distance(transform.position, Post_2.position) <= 0.5f) agent.destination = Post_1.position;



    }
}
