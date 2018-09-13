using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class Seek : SteeringBehaviour
    {
        public Transform target;
        public float stoppingDistance;
        public override Vector3 GetForce()
        {
            // Get direction (velocity) to target
            Vector3 velocity = target.position - owner.transform.position;
            // Normalize velocity (remove the magnitude part of vector)
            velocity.Normalize();
            return velocity * owner.maxSpeed; // return velocty (direction x speed)
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

