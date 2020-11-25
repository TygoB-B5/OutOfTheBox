using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    private Electricalbox electricalBox;

    public Light lampLight;
    public AudioSource lampClick;
    public Transform lampWire;
    public GameObject lampCap;
    private bool inAnim = false;
    public bool lampOn;

    void Start()
    {
        lampOn = false;
        lampLight.enabled = !lampLight.enabled;
        electricalBox = FindObjectOfType<Electricalbox>();
        CheckLampCap();
    }
    public void ClickLampWire()
    {
        if (inAnim)

            return;

        StartCoroutine(LampAnim());
    }

    public void CheckLampCap()
    {
        if (!electricalBox.electricalSwitchOn && lampOn)
            lampCap.SetActive(true);
        else
            lampCap.SetActive(false);
    }

    IEnumerator LampAnim()
    {
        inAnim = true;
        float pos = lampWire.position.y;
        lampWire.position = new Vector3(lampWire.position.x, pos -0.002f, lampWire.position.z);
        yield return new WaitForSeconds(0.1f);
        lampWire.position = new Vector3(lampWire.position.x, pos - 0.010f, lampWire.position.z);
        yield return new WaitForSeconds(0.1f);
        lampWire.position = new Vector3(lampWire.position.x, pos - 0.14f, lampWire.position.z);
        yield return new WaitForSeconds(0.1f);
        lampLight.enabled = !lampLight.enabled;
        lampOn = lampLight.enabled;
        lampClick.Play();
        CheckLampCap();
        yield return new WaitForSeconds(0.1f);
        lampWire.position = new Vector3(lampWire.position.x, pos - 0.010f, lampWire.position.z);
        yield return new WaitForSeconds(0.1f);
        lampWire.position = new Vector3(lampWire.position.x, pos - 0.005f, lampWire.position.z);
        yield return new WaitForSeconds(0.1f);
        lampWire.position = new Vector3(lampWire.position.x, pos, lampWire.position.z);
        inAnim = false;
        yield return null;
    }
}
