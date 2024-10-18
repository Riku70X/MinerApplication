using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public abstract class Worker : MonoBehaviour
{    
    //public:

    public void ChangeState(State newState)
    {
        pState = newState;
    }

    //protected:

    //Our state
    protected State pState;

    //private:

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayedUpdate());
    }

    IEnumerator DelayedUpdate()
    {
        while (true)
        {
            pState.Execute(this);

            yield return new WaitForSeconds(2.0f);
        }
    }
}
