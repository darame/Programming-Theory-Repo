using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public virtual void NameDisplay() // abstraction
    {
        Debug.Log(Name);
    }
    private string Name = "Null";
    public string t_name // encapsulation
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }


    private void OnMouseUpAsButton()
    {
        NameDisplay();
    }
}
