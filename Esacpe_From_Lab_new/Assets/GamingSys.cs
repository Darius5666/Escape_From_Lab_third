using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GamingSys : MonoBehaviour
{
    public Camera Camera;
    public Button first;
    public Button second;
    public GameObject locker1;
    public GameObject locker2;
    public GameObject Tape;
    public GameObject Cropkey;
    Vector3 tapepos;
    Vector3 keypos;
    public int Stage=1;
    void Start()
    {
        Camera.GetComponent<Transform>().position = new Vector3
        (
            -43.41f,
            0,
            -10
        );
        tapepos=Tape.transform.position;
        keypos = Cropkey.transform.position;
        Cropkey.GetComponent<Transform>().position = new Vector3(-200, 0, 0);
        Tape.GetComponent<Transform>().position = new Vector3(-200, 0, 0);
        first.onClick.AddListener(change1);
        second.onClick.AddListener(change2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void change1()
    {
        Camera.GetComponent<Transform>().position = new Vector3(0.24f, 0.0208f, -10);
        Stage++;
        locker2.SetActive(false);

    }
    void change2()
    {
        if(Stage==1)
        {
            Cropkey.GetComponent<RectTransform>().position = keypos;
            Tape.GetComponent<RectTransform>().position = tapepos;
            first.interactable = false;
           second.interactable = false;
            Stage++;
            Camera.GetComponent<Transform>().position = new Vector3(-21.96f, 0f, -10);

        }
    }
}
