using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Desire
{
    //public:

    // The state this Desire corresponds to
    public State State;

    //The value used by the comparator
    public float DesireVal;

    public Desire()
    {
        State = null; // in child classes, create a reference to an appropriate state
        DesireVal = 0.05f; // default value
    }

    // Comparator
    public int CompareTo(Desire other)
    {
        if (DesireVal < other.DesireVal) return 1;
        else if (DesireVal > other.DesireVal) return -1;
        else return 0;
    }
}
