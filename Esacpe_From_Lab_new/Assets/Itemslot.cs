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
    public Camera Camera;
    Button btn;
    public void Start()
    {
        btn =doorBtn.GetComponent<Button>();
        btn.enabled = false;
        btn.onClick.AddListener(changeRoom);
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        btn.enabled = true;
        Debug.Log("OnDrop");
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
            doorBtn.interactable = false;
        }
        
    }
}
