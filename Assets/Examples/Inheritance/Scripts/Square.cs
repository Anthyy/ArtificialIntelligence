using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IS A Derrivative of 'Shape'
public class Square : Shape
{
    // Any variable inside is referred to as "HAS A"
    // E.G: Square HAS A width, Square HAS A height

    [Header("Square")]
    public float width;
    public float height;

    public override void Draw()
    {
        print("I am a Square");
        //base.Draw();
    }
}
