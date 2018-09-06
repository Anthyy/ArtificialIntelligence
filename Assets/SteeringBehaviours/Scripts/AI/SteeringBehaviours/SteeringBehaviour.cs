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
        private void Awake()
        {
            
        }
        public virtual Vector3 GetForce()
        {
            return Vector3.zero;
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
    
