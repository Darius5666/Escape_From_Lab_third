using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSys : MonoBehaviour
{
    public GameObject locker;
    public int tasknum;
    [HideInInspector]
    public int[] complete;
    public bool iscomplete;
    // Start is called before the first frame update
    void Start()
    {
        complete = new int[tasknum];

    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
