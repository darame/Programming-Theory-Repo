using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        t_name = "Cube";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void NameDisplay() // polymorphism
    {
        Debug.Log("cube " + t_name);
    }
}
