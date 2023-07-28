using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Rectangle
{
    Rigidbody rigidBody;

    //POLYMORPHISM - Overrides the parent's Start method
    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        rigidBody = GetComponent<Rigidbody>();
    }
    protected override string GetName()
    {
        return "Cube, child of Rectangle. It jumps!";
    }

    //POLYMORPHISM - Overrides the parent's OnMouseDown method
    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        rigidBody.AddForce(Vector3.up * 500);
    }
}
