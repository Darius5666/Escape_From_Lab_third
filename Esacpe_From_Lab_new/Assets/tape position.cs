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
    // Start is called before the first frame update
    void Start()
    {PosX=GetComponent<RectTransform>().anchoredPosition.x;
     PosY=GetComponent<RectTransform>().anchoredPosition.y;
    }

    // Update is called once per frame
    void Update()
    {if ((PosX== -202) && ( PosY== 82.28))
        {
            monitor.SetActive(false);
            monitoroff.SetActive(true);
            tape.SetActive(false);

        }
     
    }
}
