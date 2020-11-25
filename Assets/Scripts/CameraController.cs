using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera cam;
    private bool isMoving = false;
    private int currentRotation;
    public float animSpeed;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (isMoving)
            return;

        if (Input.GetKeyDown(KeyCode.RightArrow)){
            StartCoroutine(MoveCamera(90));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(MoveCamera(-90));
        }
    }

    IEnumerator MoveCamera(int rotation)
    {
        isMoving = true;
        currentRotation += rotation;
        cam.fieldOfView = 70;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 90;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 95;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 100;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 105;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 110;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 120;
        yield return new WaitForSeconds(0.02f * animSpeed);



        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.03f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.03f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.transform.Rotate(Vector3.up * (rotation / 7));
        cam.transform.rotation = Quaternion.Euler(0, currentRotation, 0);


        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 120;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 110;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 105;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 100;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 95;
        yield return new WaitForSeconds(0.01f * animSpeed);
        cam.fieldOfView = 90;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 85;
        yield return new WaitForSeconds(0.02f * animSpeed);
        cam.fieldOfView = 70;
        yield return new WaitForSeconds(0.02f * animSpeed);

        isMoving = false;

        yield return null;
    }
}
