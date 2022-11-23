using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyRandomizer : MonoBehaviour
{
    private NavMeshAgent agent;
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        RondomizeAgent();
    }

    private void RondomizeAgent()
    {
        float randomSpeed = Random.Range(3.5f, 5f);
        float randomAngularSpeed = Random.Range(200f, 400f);
        float randomAcceleration = Random.Range(6f, 10f);
        int randomQality = Random.Range(0, 3);
        if (randomQality == 0)
        {
            agent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
        }
        else if (randomQality == 0)
        {
            agent.obstacleAvoidanceType = ObstacleAvoidanceType.GoodQualityObstacleAvoidance;
        }
        else
        {
            agent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        }

        agent.speed = randomSpeed;
        agent.angularSpeed = randomAngularSpeed;
        agent.acceleration = randomAcceleration;
    }
    
}
