using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private GetActionInput aci;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        aci = FindObjectOfType<GetActionInput>();
    }
    void Update()
    {
        GetMouseInput();
    }


    void GetMouseInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                aci.ActivateAction(hit.transform);
            }
        }
    }
}
