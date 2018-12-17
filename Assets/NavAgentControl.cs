using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentControl : MonoBehaviour
{
    private Vector3 wanderingPoint;
    public NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        wanderingPoint = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(wanderingPoint);
        // transform.position = Vector3.MoveTowards(transform.position, new Vector3(wanderingPoint.x, transform.position.y, wanderingPoint.z), Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, wanderingPoint) < 1)
        {
            agent.ResetPath();
            wanderingPoint = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));
            agent.SetDestination(wanderingPoint);

        }
    }
}
