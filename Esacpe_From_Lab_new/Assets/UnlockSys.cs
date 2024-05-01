using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSys : MonoBehaviour
{
    public GameObject locker;
    public int tasknum;
    [HideInInspector]
    public int[] complete;
    private bool iscomplete;
    // Start is called before the first frame update
    void Start()
    {
        locker.SetActive(false);
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
            locker.SetActive(true);
        }
    }
}
