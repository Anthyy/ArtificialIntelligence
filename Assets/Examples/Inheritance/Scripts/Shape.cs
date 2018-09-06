using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract - Can only Inherit class, 
// cannot create instance of it
public abstract class Shape : MonoBehaviour
{
    [Header("Shape")]
    public Vector3 position;
    public float scale;
    [SerializeField]
    protected string nameToPrint;

    void Start()
    {
        Draw();    
    }

    // virtual - "This function can be overriden"

    public virtual void Draw()
    {
        print(nameToPrint);
    }
}