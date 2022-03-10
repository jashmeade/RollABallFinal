using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DetectPlayer : MonoBehaviour
{
    Sensor sensor;
    public GameObject Player;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sensor = GetComponentInChildren<Sensor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sensor.isDetecting)
        {
            agent.destination = Player.transform.position;
        }

    }
}
