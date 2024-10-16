using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public abstract class Worker : MonoBehaviour
{
    //Our state
    protected State pState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pState.Execute(this);
    }

    public void ChangeState(State newState)
    {
        pState = newState;
    }
}
