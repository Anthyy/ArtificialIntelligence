﻿using System.Collections;
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
            return base.GetForce();
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

