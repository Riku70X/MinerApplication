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

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(DelayedUpdate());
    }

    private IEnumerator DelayedUpdate()
    {
        while (true)
        {
            ChooseState();

            pState.Execute(this);

            Debug.Log(pState.GetType());

            if (pState.Equals(new MiningForGold()))
            {
                Debug.Log("TRUE");
            }

            yield return new WaitForSeconds(2.0f);
        }
    }
}
