using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public AIStateMachine aIStateMachine;
    public AiStateId initState;
    public NavMeshAgent NavMeshagent;
    public Transform player;
    public GameObject Weapon;

    void Start(){
        NavMeshagent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        aIStateMachine = new AIStateMachine(this);
        aIStateMachine.RegisterState(new AIShoot());
        aIStateMachine.RegisterState(new AIChasePlayerState());
        aIStateMachine.RegisterState(new AIIdleState());
        aIStateMachine.ChangeState(initState);
    }

    void Update(){
        aIStateMachine.Update();
    }
}
