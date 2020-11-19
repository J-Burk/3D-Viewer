using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErsatzteileScript : MonoBehaviour
{
    public GameObject BackButton;
    public GameObject Buttons;

    public GameObject MainObject;
    public GameObject Ersatzteil1;
    public GameObject Ersatzteil2;
    public GameObject Ersatzteil3;
    public GameObject Ersatzteil4_1;
    public GameObject Ersatzteil4_2;
    public GameObject Ersatzteil5_1;
    public GameObject Ersatzteil5_2;
    public GameObject Ersatzteil6_1;
    public GameObject Ersatzteil6_2;
    public GameObject Ersatzteil6_3;

    public bool Teil1Active;
    public bool Teil1MoveForward;
    public bool Teil1MoveBackward;
    public bool Teil2Active;
    public bool Teil2MoveForward;
    public bool Teil2MoveBackward;
    public bool Teil3Active;
    public bool Teil3MoveForward;
    public bool Teil3MoveBackward;
    public bool Teil4Active;
    public bool Teil4MoveForward;
    public bool Teil4MoveBackward;
    public bool Teil5Active;
    public bool Teil5MoveForward;
    public bool Teil5MoveBackward;
    public bool Teil6Active;
    public bool Teil6MoveForward;
    public bool Teil6MoveBackward;

    void Start()
    {
        BackButton.SetActive(false);
    }

    void Update()
    {
        // Steuerung der Ersatzteile zum Rausfahren
        //Ersatzteil1
        if (Teil1MoveForward)
        {
            Ersatzteil1.transform.position += new Vector3(0, 0, 0.1f);
            if (Ersatzteil1.transform.position.z >= 5)
            {
                Teil1MoveForward = false;
                Ersatzteil1.transform.position = new Vector3(0, 0, 5);
            }
        }
        else if (Teil1MoveBackward)
        {
            Ersatzteil1.transform.position -= new Vector3(0, 0, 0.1f);
            if (Ersatzteil1.transform.position.z <= 0)
            {
                Teil1MoveBackward = false;
                Ersatzteil1.transform.position = new Vector3(0, 0, 0);
            }
        }
        //Ersatzteil2
        if (Teil2MoveForward)
        {
            Ersatzteil2.transform.position -= new Vector3(0.1f, 0.1f, 0);
            if (Ersatzteil2.transform.position.y <= -2)
            {
                Teil2MoveForward = false;
                Ersatzteil2.transform.position = new Vector3(-2, -2, 0);
            }
        }
        else if (Teil2MoveBackward)
        {
            Ersatzteil2.transform.position += new Vector3(0.1f, 0.1f, 0);
            if (Ersatzteil2.transform.position.y >= 0)
            {
                Teil2MoveBackward = false;
                Ersatzteil2.transform.position = new Vector3(0, 0, 0);
            }
        }
        //Ersatzteil3
        if (Teil3MoveForward)
        {
            Ersatzteil3.transform.position -= new Vector3(0, 0, 0.1f);
            if (Ersatzteil3.transform.position.z <= -5)
            {
                Teil3MoveForward = false;
                Ersatzteil3.transform.position = new Vector3(0, 0, -5);
            }
        }
        else if (Teil3MoveBackward)
        {
            Ersatzteil3.transform.position += new Vector3(0, 0, 0.1f);
            if (Ersatzteil3.transform.position.z >= 0)
            {
                Teil3MoveBackward = false;
                Ersatzteil3.transform.position = new Vector3(0, 0, 0);
            }
        }
        //Ersatzteil4
        if (Teil4MoveForward)
        {
            Ersatzteil4_1.transform.position -= new Vector3(0.1f, 0, 0);
            Ersatzteil4_2.transform.position += new Vector3(0.1f, 0, 0);
            if (Ersatzteil4_1.transform.position.x <= -5)
            {
                Teil4MoveForward = false;
                Ersatzteil4_1.transform.position = new Vector3(-5, 0, 0);
                Ersatzteil4_2.transform.position = new Vector3(5, 0, 0);
            }
        }
        else if (Teil4MoveBackward)
        {
            Ersatzteil4_1.transform.position += new Vector3(0.1f, 0, 0);
            Ersatzteil4_2.transform.position -= new Vector3(0.1f, 0, 0);
            if (Ersatzteil4_1.transform.position.x >= 0)
            {
                Teil4MoveBackward = false;
                Ersatzteil4_1.transform.position = new Vector3(0, 0, 0);
                Ersatzteil4_2.transform.position = new Vector3(0, 0, 0);
            }
        }
        //Ersatzteil5
        if (Teil5MoveForward)
        {
            Ersatzteil5_1.transform.position -= new Vector3(0, 0, 0.05f);
            Ersatzteil5_2.transform.position -= new Vector3(0, 0, 0.1f);
            if (Ersatzteil5_2.transform.position.z <= -5)
            {
                Teil5MoveForward = false;
                Ersatzteil5_1.transform.position = new Vector3(0, 0, -2.5f);
                Ersatzteil5_2.transform.position = new Vector3(0, 0, -5);
            }
        }
        else if (Teil5MoveBackward)
        {
            Ersatzteil5_1.transform.position += new Vector3(0, 0, 0.05f);
            Ersatzteil5_2.transform.position += new Vector3(0, 0, 0.1f);
            if (Ersatzteil5_2.transform.position.z >= 0)
            {
                Teil5MoveBackward = false;
                Ersatzteil5_1.transform.position = new Vector3(0, 0, 0);
                Ersatzteil5_2.transform.position = new Vector3(0, 0, 0);
            }
        }
        //Ersatzteil6
        if (Teil6MoveForward)
        {
            Ersatzteil6_1.transform.position -= new Vector3(0, 0, 0.05f);
            Ersatzteil6_2.transform.position -= new Vector3(0, 0, 0.07f);
            Ersatzteil6_3.transform.position -= new Vector3(0, 0, 0.1f);
            if (Ersatzteil6_3.transform.position.z <= -5)
            {
                Teil6MoveForward = false;
                Ersatzteil6_1.transform.position = new Vector3(0, 0, -2.5f);
                Ersatzteil6_2.transform.position = new Vector3(0, 0, -3.5f);
                Ersatzteil6_3.transform.position = new Vector3(0, 0, -5);
            }
        }
        else if (Teil6MoveBackward)
        {
            Ersatzteil6_1.transform.position += new Vector3(0, 0, 0.05f);
            Ersatzteil6_2.transform.position += new Vector3(0, 0, 0.07f);
            Ersatzteil6_3.transform.position += new Vector3(0, 0, 0.1f);
            if (Ersatzteil6_3.transform.position.z >= 0)
            {
                Teil6MoveBackward = false;
                Ersatzteil6_1.transform.position = new Vector3(0, 0, 0);
                Ersatzteil6_2.transform.position = new Vector3(0, 0, 0);
                Ersatzteil6_3.transform.position = new Vector3(0, 0, 0);
            }
        }
    }
    // Buttonzuweisung
    public void ErsatzteilOne()
    {
        if (!Teil1Active)
        {
            Teil1MoveForward = true;
            Teil1MoveBackward = false;
            Teil1Active = true;
        }
        else
        {
            Teil1MoveForward = false;
            Teil1MoveBackward = true;
            Teil1Active = false;
        }
    }
    public void ErsatzteilTwo()
    {
        if (!Teil2Active)
        {
            Teil2MoveForward = true;
            Teil2MoveBackward = false;
            Teil2Active = true;
        }
        else
        {
            Teil2MoveForward = false;
            Teil2MoveBackward = true;
            Teil2Active = false;
        }
    }
    public void ErsatzteilThree()
    {
        if (!Teil3Active)
        {
            Teil3MoveForward = true;
            Teil3MoveBackward = false;
            Teil3Active = true;
        }
        else
        {
            Teil3MoveForward = false;
            Teil3MoveBackward = true;
            Teil3Active = false;
        }
    }
    public void ErsatzteilFour()
    {
        if (!Teil4Active)
        {
            Teil4MoveForward = true;
            Teil4MoveBackward = false;
            Teil4Active = true;
        }
        else
        {
            Teil4MoveForward = false;
            Teil4MoveBackward = true;
            Teil4Active = false;
        }
    }
    public void ErsatzteilFive()
    {
        if (!Teil5Active)
        {
            Teil5MoveForward = true;
            Teil5MoveBackward = false;
            Teil5Active = true;
        }
        else
        {
            Teil5MoveForward = false;
            Teil5MoveBackward = true;
            Teil5Active = false;
        }
    }
    public void ErsatzteilSix()
    {
        if (!Teil6Active)
        {
            Teil6MoveForward = true;
            Teil6MoveBackward = false;
            Teil6Active = true;
        }
        else
        {
            Teil6MoveForward = false;
            Teil6MoveBackward = true;
            Teil6Active = false;
        }
    }

}
