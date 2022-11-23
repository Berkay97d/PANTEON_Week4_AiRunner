using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private Transform targetPos;
    


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        MoveToFinish();
    }
    
    private void MoveToFinish() //FİNİSHE DOĞRU KOŞ
    {
        agent.destination = targetPos.position;
    }
}
