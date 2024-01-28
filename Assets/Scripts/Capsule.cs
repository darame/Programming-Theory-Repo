using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Capsule : Shape // inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        t_name = "Capsule";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void NameDisplay() // polymorphism
    {
        Debug.Log("first" + t_name);
    }
}
