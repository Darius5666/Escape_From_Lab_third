using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UnlockSys : MonoBehaviour
{
    public Image locker;
    public int tasknum;
    [HideInInspector]
    public int[] complete;
    private bool iscomplete;
    // Start is called before the first frame update
    void Start()
    {
        locker.enabled=false;
        complete = new int[tasknum];

    }

    
    // Update is called once per frame
    void Update()
    {
        iscomplete = true;
         foreach (int i in complete)
        {
            if (i != 1)
            {
                iscomplete = false;
                break;
            }
        }
        if (iscomplete)
        {
            Debug.Log("Hi");
            locker.enabled=true;
        }
    }
}
