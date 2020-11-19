using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchscreenScript : MonoBehaviour
{
    public GameObject ObjectFolder;
    public GameObject ActObject;
    public GameObject CamFolder;
    public GameObject Cam;
    public GameObject TurnButton;
    public GameObject MoveButton;

    float rotationSpeed;
    float minCamDistance;
    float maxCamDistance;
    float camDistance;
    float zoom;

    public bool TurnMovement;

    //PC Eingabe
    public float mouseScroll;
    public bool leftKlick;
    public bool rightKlick;

    void Start()
    {
        rotationSpeed = 0.5f;
        minCamDistance = 0;
        maxCamDistance = 10;
        leftKlick = false;
        TurnMovement = true;
    }

    void Update()
    {
        if (Input.touchSupported)
        {
            Cam.transform.position += Cam.transform.forward * zoom * 100 * Time.deltaTime;
            camDistance = Vector3.Distance(CamFolder.transform.position, Cam.transform.position);
            if (Input.touchCount == 1)
            {
                if (TurnMovement)
                {
                    ObjectFolder.transform.Rotate(0, -Input.GetTouch(0).deltaPosition.x * rotationSpeed, 0);
                    ActObject.transform.Rotate(Input.GetTouch(0).deltaPosition.y * rotationSpeed, 0, 0);
                }
                else if (!TurnMovement)
                {
                    Cam.transform.position -= new Vector3(Input.GetTouch(0).deltaPosition.x * 0.1f, Input.GetTouch(0).deltaPosition.y * 0.1f, 0);
                }
            }
            if (Input.touchCount == 2)
            {
                var pos1 = Input.GetTouch(0).position;
                var pos2 = Input.GetTouch(1).position;
                var pos1b = Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition;
                var pos2b = Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition;
                if (Vector3.Distance(pos1, pos2) > Vector3.Distance(pos1b, pos2b))
                {
                    zoom = 0.5f;
                }
                else if (Vector3.Distance(pos1, pos2) < Vector3.Distance(pos1b, pos2b))
                {
                    zoom = -0.5f;
                }
                else
                {
                    zoom = 0;
                }

                Cam.transform.position += Cam.transform.forward * zoom * 100 * Time.deltaTime;
            }
            if (Input.touchCount != 2)
            {
                zoom = 0;
            }
        }
    }


    public void RueckSaetz()
    {
        Cam.transform.position = new Vector3(0, 0, -60);
        ObjectFolder.transform.rotation = Quaternion.Euler(0, 0, 0);
        ActObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void ChangeMoveArt()
    {
        TurnMovement = !TurnMovement;
    }

    public void MoveController()
    {
        if (TurnMovement)
        {
            TurnButton.SetActive(true);
            MoveButton.SetActive(false);
        }
        else
        {
            TurnButton.SetActive(false);
            MoveButton.SetActive(true);
        }
    }

}
