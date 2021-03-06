﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Intro // Namespaces are used so that Scripts can be categorised differently so that they don't clash, as scripts ignore folder structure.
{
    public class Waypoints : MonoBehaviour
    {
        // Declaration
        public enum State // enums (enumerators) associate names with numbers
        {
            Patrol, // = 0 by default
            Seek // = 1 by default
        }

        // Definition
        public State currentState = State.Patrol;

        public NavMeshAgent agent;
        public Transform target;
        public float seekRadius = 5f;

        public Transform waypointParent;
        public float moveSpeed = 0.1f; // or just "public float moveSpeed;" but remember to adjust the slider so it has some speed.
        public float stoppingDistance = 1f; // the variable name is always something that you make up (in this case "stoppingDistance")

        // Creates a collection of Transforms
        private Transform[] waypoints;
        private int currentIndex = 1;


        /*
         * [] - Brackets
         * () - Parenthesis
         * {} - Braces (or Curly Braces)
         */

        // CTRL + M + O = Fold Code
        // CTRL + M + P = Unfold Code

        // Use this for initialization

        void Patrol()
        {
            Transform point = waypoints[currentIndex]; // so you can actually declare variables inside a function as well (except they'll only be able to be used inside that specific function and will unable to be referenced outside of it)

            float distance = Vector3.Distance(transform.position, point.position);
            if (distance < stoppingDistance)
            {
                // currentIndex = currentIndex + 1
                currentIndex++;
                if (currentIndex >= waypoints.Length)
                {
                    currentIndex = 1;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, point.position, moveSpeed); // Goes through objects to seek target
            // agent.SetDestination(point.position); // Goes around objects to seek target
                                                  
            float distToTarget = Vector3.Distance(transform.position, point.position);
            if (distToTarget < seekRadius)
            {
                currentState = State.Seek;
            }
        }

        void Seek()
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed); // The agent will go through obstacles to get to the target          
            float distToTarget = Vector3.Distance(transform.position, target.position);
            if (distToTarget > seekRadius)
            {
                currentState = State.Patrol;
            }
        }

        void Start()
        {
            //Getting children of waypointParent
            waypoints = waypointParent.GetComponentsInChildren<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            // Switch current state
            switch (currentState)
            {
                // If we are in Patrol
                case State.Patrol:
                    // Call Patrol()
                    Patrol();
                    break;
                // If we are in Seek
                case State.Seek:
                    // Call Seek()
                    Seek();
                    break;
                // Failsafe (if there is an error, default to default)
                default:
                    break;
            }           
        }
    }
}
