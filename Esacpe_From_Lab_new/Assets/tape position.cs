using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tapeposition : MonoBehaviour
{
    public GameObject monitor;
    public GameObject monitoroff;
    public GameObject tape;
    float PosX;
    float PosY;
    float TPosX;
    float TPosY;
    // Start is called before the first frame update
    void Start()
    {PosX=GetComponent<RectTransform>().anchoredPosition.x;
     PosY=GetComponent<RectTransform>().anchoredPosition.y;
     TPosX = monitor.GetComponent<RectTransform>().anchoredPosition.x;
     TPosY = monitor.GetComponent<RectTransform>().anchoredPosition.y;
        monitoroff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PosX = GetComponent<RectTransform>().anchoredPosition.x;
        PosY = GetComponent<RectTransform>().anchoredPosition.y;
        Debug.Log(PosX + " " + PosY);
        if ((PosX == TPosX) && ( PosY == TPosY))
        {
            monitoroff.SetActive(true);
            monitor.SetActive(false);
        }
     
    }
}
