using UnityEngine;
using UnityEngine.AI;

public class GuardMovement : MonoBehaviour
{
    public Transform Post_1;
    public Transform Post_2;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Post_1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.destination == Post_1.position) agent.destination = Post_2.position;
        else agent.destination = Post_1.position;
    }
}
