using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tapeposition : MonoBehaviour
{
    public GameObject monitor;
    public GameObject monitoroff;
    float PosX;
    float PosY;
    float PosMX;
    float PosMY;
    // Start is called before the first frame update
    void Start()
    {PosX=GetComponent<Transform>().position.x;
     PosY=GetComponent<Transform>().position.y;
     PosMX = monitor.GetComponent<Transform>().position.x;
     PosMX = monitor.GetComponent<Transform>().position.y;
    }

    // Update is called once per frame
    void Update()
    {if (PosMX-10<= PosX || PosX <= PosMX+10 & PosMY - 10 <= PosY || PosY <= PosMY + 10)
        {
            monitor.SetActive(false);
            monitoroff.SetActive(true);

        }
     
    }
}
