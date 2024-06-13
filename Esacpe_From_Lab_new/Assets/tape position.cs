using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tapeposition : MonoBehaviour
{
    public GameObject monitor;
    public GameObject monitoroff;
    public GameObject tape;
    public Button door;
    public int num;
    public int id;
    public GameObject Gamesys;
    float PosX;
    float PosY;
    float TPosX;
    float TPosY;
    int stage;
    // Start is called before the first frame update
    void Start()
    {PosX=GetComponent<RectTransform>().anchoredPosition.x;
     PosY=GetComponent<RectTransform>().anchoredPosition.y;
     stage = Gamesys.GetComponent<GamingSys>().Stage;
     TPosX = monitor.GetComponent<RectTransform>().anchoredPosition.x;
     TPosY = monitor.GetComponent<RectTransform>().anchoredPosition.y;

    }

    // Update is called once per frame
    void Update()
    {
        stage = Gamesys.GetComponent<GamingSys>().Stage;
        if (stage == num)
        {
            monitor.SetActive(true);
            monitoroff.SetActive(false);
        }
        else
        {
            monitoroff.SetActive(false);
            monitor.SetActive(false);
        }
        if (stage == 3)
        {
            monitor.SetActive(false) ;
            tape.SetActive(false);
        }
        PosX = GetComponent<RectTransform>().anchoredPosition.x;
        PosY = GetComponent<RectTransform>().anchoredPosition.y;
        if ((PosX == TPosX) && ( PosY == TPosY))
        {
            if(stage == 2 && id == 1)
            {
                door.interactable = true;
            }
                
            
            monitoroff.SetActive(true);
            monitor.SetActive(false);
        }

     
    }
}
