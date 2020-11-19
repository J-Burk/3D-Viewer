using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public GameObject CamFolder;
    public GameObject CamHorizontalFolder;
    public GameObject Cam;

    public GameObject ActObject;

    public GameObject TurnButton;
    public GameObject MoveButton;

    public bool leftKlick;
    public bool rightKlick;
    public bool autoDrift;
    public bool TurnMovement;

    float mouseScroll;
    float rotationSpeed;
    float zoom;

    void Start()
    {
        rotationSpeed = 0.5f;
        leftKlick = false;
        autoDrift = true;
        TurnMovement = true;
        TurnButton.SetActive(true);
        MoveButton.SetActive(false);
    }

    void Update()
    {
        if (autoDrift)
        {
            CamFolder.transform.Rotate(0, 0.1f * rotationSpeed, 0);
        }

        //PC Eingabe
        //mouseScroll = Input.GetAxis("Mouse ScrollWheel") * 1;
        //Cam.transform.position += Cam.transform.forward * mouseScroll * 100 * Time.deltaTime;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    leftKlick = true;
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    leftKlick = false;
        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    rightKlick = true;
        //}
        //if (Input.GetMouseButtonUp(1))
        //{
        //    rightKlick = false;
        //}
        //if (leftKlick)
        //{
        //    CamHorizontalFolder.transform.Rotate(-Input.GetAxis("Mouse Y") * rotationSpeed * 10, 0, 0);
        //    CamFolder.transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed * 10, 0);
        //}
        //if (rightKlick)
        //{
        //    Cam.transform.position -= Cam.transform.up * Input.GetAxis("Mouse Y") * 0.2f;
        //    Cam.transform.position -= Cam.transform.right * Input.GetAxis("Mouse X") * 0.2f;
        //}

        //TouchScreenInput
        if (Input.touchSupported)
        {
            Cam.transform.position += Cam.transform.forward * zoom * 100 * Time.deltaTime;
            if (Input.touchCount == 1)
            {
                if (TurnMovement)
                {
                    CamFolder.transform.Rotate(0, +Input.GetTouch(0).deltaPosition.x * rotationSpeed, 0);
                    CamHorizontalFolder.transform.Rotate(-Input.GetTouch(0).deltaPosition.y * rotationSpeed, 0, 0);
                }
                else if (!TurnMovement)
                {
                    Cam.transform.position -= new Vector3(Input.GetTouch(0).deltaPosition.x * 0.01f, Input.GetTouch(0).deltaPosition.y * 0.01f, 0);
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
                    zoom = 0.1f;
                }
                else if (Vector3.Distance(pos1, pos2) < Vector3.Distance(pos1b, pos2b))
                {
                    zoom = -0.1f;
                }
                else
                {
                    zoom = 0;
                }

                Cam.transform.position += Cam.transform.forward * zoom * 0.01f * Time.deltaTime;
            }
            if (Input.touchCount != 2)
            {
                zoom = 0;
            }
        }
    }

    public void AutoDrift()
    {
        if (!autoDrift)
        {
            autoDrift = true;
        }
        else
        {
            autoDrift = false;
        }
    }

    public void RueckSaetz()
    {
        CamFolder.transform.rotation = Quaternion.Euler(0, 35, 0);
        CamHorizontalFolder.transform.rotation = Quaternion.Euler(0, 0, 0);
        Cam.transform.position = new Vector3(0, 0, -10);
    }
    public void ChangeMoveArt()
    {
        TurnMovement = !TurnMovement;
        MoveController();
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
