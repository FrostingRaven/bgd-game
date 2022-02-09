using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIIdleState : AIState
{
    public AiStateId GetId(){
        return AiStateId.IdleState;
    }

    public void Enter(Agent agent){
        
    }

    public void Update(Agent agent){
        Vector3 playerDirection = agent.player.position-agent.transform.position;
        if (playerDirection.magnitude>10.0f){
            return;
        }
        Vector3 agentDirection = agent.transform.forward;
        playerDirection.Normalize();
        float dotProduct = Vector3.Dot(playerDirection,agentDirection);
        if (dotProduct>0.0f){
            if (agent.Weapon.name=="AI_Knife"){
                 agent.aIStateMachine.ChangeState(AiStateId.ChasePlayer);
            }
            else{
                agent.aIStateMachine.ChangeState(AiStateId.ChasePlayer);
            }
        }
    }

    public void Exit (Agent agent){

    }
}
