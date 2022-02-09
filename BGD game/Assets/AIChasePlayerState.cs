using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIChasePlayerState : AIState
{
    public float maxTime=1.0f;
    public float maxDistance=1.0f;
    float timer=0.0f;

    public AiStateId GetId(){
        return AiStateId.ChasePlayer;
    }

    public void Enter(Agent agent){
    }

    public void Update(Agent agent){

        timer-=Time.deltaTime;
        if (!agent.NavMeshagent.hasPath){
            agent.NavMeshagent.destination = agent.player.position;
        }
        if (timer<0.0f){
            Vector3 direction = (agent.player.position-agent.NavMeshagent.destination);
            direction.y=0;
            if(direction.sqrMagnitude>maxDistance*maxDistance){
                if(agent.NavMeshagent.pathStatus!=NavMeshPathStatus.PathPartial)
                agent.NavMeshagent.destination=agent.player.position;       
            }
            timer=maxTime;
        }
    }

    public void Exit(Agent agent){

    }
}
