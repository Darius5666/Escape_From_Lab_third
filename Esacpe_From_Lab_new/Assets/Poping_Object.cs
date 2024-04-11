using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Poping_Object : MonoBehaviour
{
    public Button Target ;
    public Image Target_Img;
    public Button Background;
    public int Tasknum;
    private bool isClick=false;
    public GameObject me; 
    void Start()
    {
        
        Button btn=Target.GetComponent<Button>();
        Button button=Background.GetComponent<Button>();
        Target_Img.enabled = false;
        btn.onClick.AddListener(ShowImage);
        button.onClick.AddListener(GoBack);
    }

    // Update is called once per frame
    void Update()
    {

            
    }
    void ShowImage()
    {
        me.SetActive(false);
        Target_Img.enabled = true;
            Debug.Log(isClick);
        isClick= true;
        
    }
    void GoBack()
    {
        if (isClick)
        {
            me.SetActive(true);
            Target_Img.enabled = false;
            Debug.Log(isClick);
            isClick = false;
        }
        
    }
}
