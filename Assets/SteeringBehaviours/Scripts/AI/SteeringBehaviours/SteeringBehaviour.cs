using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    // "SteeringBehaviour" will only work if attached to AIAgent
    [RequireComponent(typeof(AIAgent))]
    public abstract class SteeringBehaviour : MonoBehaviour
    {

        public float weighting; // How much weighting does the behaviour have over other behaviours
        public AIAgent owner; // Reference to AIAgent owner of behavour

        // Awake runs regardless whether or not the GameObject is enabled
        private void Awake() // Runs before Start
        {
            owner = GetComponent<AIAgent>();
        }
        public virtual Vector3 GetForce()
        {
            return Vector3.zero;
        }       
    }
}  
    
