using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static UnityEngine.ParticleSystem;


public class Itemslot : MonoBehaviour,IDropHandler
{
    public Button doorBtn;
    public int num=0;
    public int index = 0;
    public int id = 0;
    public GameObject GamingSys;
    public Camera Camera;
    Button btn;
    public void Start()
    {
       
            btn = doorBtn.GetComponent<Button>();
            btn.enabled = true;
            btn.onClick.AddListener(changeRoom);
    }
    public void OnDrop(PointerEventData eventData)
    {
        
        Debug.Log("OnDrop");
        
        if (id==1&&doorBtn.interactable == false)
        {
            Camera.GetComponent<Transform>().position = new Vector3(-65.96987f, 0.3670923f, -10);
            GamingSys.GetComponent<GamingSys>().Stage=3;
        }
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;
         }

    }
    void changeRoom()
    {
        if (index == 1)
        {
            Camera.GetComponent<Transform>().position = new Vector3(-43.41f,0,-10);
            doorBtn.interactable=false;
        }
        if(index == 2&&num==1)
        {
                Camera.GetComponent<Transform>().position = new Vector3(-43.41f, 0, -10);
                doorBtn.interactable = false;
        }
        
    }
}
