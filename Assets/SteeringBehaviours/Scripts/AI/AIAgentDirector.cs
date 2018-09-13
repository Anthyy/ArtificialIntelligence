using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace SteeringBehaviours
{


    public class AIAgentDirector : MonoBehaviour
    {

        public AIAgent agent;
        public Transform placeholderPoint;
        private void OnDrawGizmosSelected()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Draw a line from the 
            // - start; Where the ray starts from
            // - end; Where the ray is going
            Gizmos.color = Color.red;
            Gizmos.DrawLine(camRay.origin, camRay.origin + camRay.direction * 1000f);
        }

        // FixedUpdate is called at a specific frame
        void FixedUpdate()
        {
            if (Input.GetMouseButtonDown(0)) // You don't use "GetKey." here because the mouse buttons aren't keys
            {
                // Try to get seek component on agent
                Seek seek = agent.GetComponent<Seek>();
                // if seek is not null
                if (seek)
                {
                    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(camRay, out hit, 1000f))
                    {
                        // Update the transform's position
                        placeholderPoint.position = hit.point;
                        // Update seek's target (which you might not need to do)
                        seek.target = placeholderPoint;
                    }
                }
               
            }
        }
    }
}
