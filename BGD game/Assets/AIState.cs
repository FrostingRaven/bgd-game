using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AiStateId{
    ChasePlayer,
    IdleState,
    ShootState
}

public interface AIState 
{
    AiStateId GetId();
    void Enter(Agent agent);
    void Update(Agent agent);
    void Exit(Agent agent);
}
