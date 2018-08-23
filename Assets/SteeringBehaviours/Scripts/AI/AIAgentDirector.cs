using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SteeringBehaviours
{


    public class AIAgentDirector : MonoBehaviour
    {

        public AIAgent agent;

        // FixedUpdate is called at a specific frame
        void FixedUpdate()
        {
            // If Get Mouse Button Down (0)
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit, 1000f))
            {
                agent.SetTarget(hit.point);
            }       
            
        }
    }
}
