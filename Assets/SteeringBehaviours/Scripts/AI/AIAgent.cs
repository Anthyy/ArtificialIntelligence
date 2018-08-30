﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SteeringBehaviours
{

    public class AIAgent : MonoBehaviour
    {
        // Reference to agent component
        public NavMeshAgent agent;

        private Vector3 point = Vector3.zero;

        // Update is called once per frame
        void Update()
        {
            // if there is a point set
            if(point.magnitude > 0)
            {
                // set the agent's destination to that point
                agent.SetDestination(point);
            }
            
        }

        public void SetTarget(Vector3 point)
        {
            this.point = point; // sometimes you actually NEED to use "this." in order to clarify which variable belongs
        }
    }
}
