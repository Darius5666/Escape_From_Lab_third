using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.ComponentModel;

public class Poping_Object : MonoBehaviour
{
    public Button Target ;
    public Image Target_Img;
    public Button Background;
    public int Tasknum;
    private bool isClick=false;
    public GameObject me;
    public GameObject unlock;
    void Start()
    {

        Button btn = Target.GetComponent<Button>();
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
        unlock.GetComponent<UnlockSys>().complete[Tasknum] = 1;
        Target_Img.enabled = true;
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
