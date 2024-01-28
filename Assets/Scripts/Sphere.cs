using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        t_name = "Sphere";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void NameDisplay() // polymorphism
    {
        Debug.Log("second " + t_name);
    }
}
