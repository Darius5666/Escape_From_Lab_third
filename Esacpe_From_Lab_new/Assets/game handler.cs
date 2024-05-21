using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class gamehandler : MonoBehaviour, IPointerDownHandler { 
   

    public void OnPointerDown (PointerEventData eventData) {
        Debug.Log("OnPointerDown");
    }


}
    
