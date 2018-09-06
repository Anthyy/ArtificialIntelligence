using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IS A Derrivative of 'Shape'
public class Circle : Shape
{
    [Header("Circle")]
    public float radius;

    public override void Draw()
    {
        print("I am a Circle");

        //        base.Draw(); // Call the one in the base class
    }
}
