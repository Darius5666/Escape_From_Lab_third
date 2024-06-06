using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Itemslot : MonoBehaviour,IDropHandler
{
    public int num=0;
    public int index = 0;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            if(index==1) {
                 num = 1;
            }
            if (index==2)
            {
                if(num==0)
                {
                    Debug.Log("aaaaaa");
                }
                else
                {
                    Debug.Log("Pass");  
                }
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition=GetComponent<RectTransform>().anchoredPosition;

         }
    }
}
