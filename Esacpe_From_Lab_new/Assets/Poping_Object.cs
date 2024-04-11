using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Poping_Object : MonoBehaviour
{
    public Button Target ;
    public Image Target_Img;
    public Button Background;
    private bool isClick=false;
    void Start()
    {
            Button btn=Target.GetComponent<Button>();
            Button button=Background.GetComponent<Button>();
            
            btn.onClick.AddListener(ShowImage);
            button.onClick.AddListener(GoBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowImage()
    {
        Debug.Log("Hi");
        Target_Img.enabled = true;
    }
    void GoBack()
    {

            Target_Img.enabled = false;
    }
}
