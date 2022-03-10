using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFlee : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject Player;
    public float EnemyDistanceRun = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        Debug.Log("Distance: " + distance);

        if(distance < EnemyDistanceRun)
        {
            Vector3 dirtoPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirtoPlayer;

            agent.SetDestination(newPos);
        }

    }
}
