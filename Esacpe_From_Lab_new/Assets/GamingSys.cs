using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamingSys : MonoBehaviour
{
    public Camera Camera;
    public Button first;
    void Start()
    {
        Camera.GetComponent<Transform>().position = new Vector3
        (
            -43.41f,
            0,
            -10
        );
        first.onClick.AddListener(change);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void change()
    {
        Camera.GetComponent<Transform>().position = new Vector3(0.24f, 0.0208f, -10);
    }
}
