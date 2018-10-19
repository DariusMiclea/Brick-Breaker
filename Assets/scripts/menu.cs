using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;


public class menu : MonoBehaviour
{
    public Button button;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        if (Time.timeScale != 0)
            Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
