using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public abstract class Worker : MonoBehaviour
{    
    //protected:

    // State Machine
    protected abstract void ChooseState();

    protected void ChangeState(State newState)
    {
        pState = newState;
    }

    // Our state
    protected State pState;

    //private:

    private void Start()
    {
        StartCoroutine(UpdateWithDelay());
    }

    private IEnumerator UpdateWithDelay()
    {
        while (true)
        {
            ChooseState();

            pState.Execute(this);

            yield return new WaitForSeconds(2.0f);
        }
    }
}
