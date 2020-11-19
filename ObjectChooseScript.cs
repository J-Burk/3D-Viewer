using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChooseScript : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;

    int ActObj;

    void Start()
    {
        ActObj = 1;
        Object1.SetActive(true);
        Object2.SetActive(false);
        Object3.SetActive(false);
    }

    void Update()
    {
        switch (ActObj)
        {
            case 1:
                Object1.SetActive(true);
                Object2.SetActive(false);
                Object3.SetActive(false);
                break;
            case 2:
                Object1.SetActive(false);
                Object2.SetActive(true);
                Object3.SetActive(false);
                break;
            case 3:
                Object1.SetActive(false);
                Object2.SetActive(false);
                Object3.SetActive(true);
                break;
        }
    }

    public void ButtonOne()
    {
        ActObj = 1;
    }
    public void ButtonTwo()
    {
        ActObj = 2;
    }
    public void ButtoThree()
    {
        ActObj = 3;
    }
}
