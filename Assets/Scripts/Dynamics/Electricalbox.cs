using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricalbox : MonoBehaviour
{
    public bool electricalSwitchOn;
    public Light[] BigLights;
    private bool isAnim = false;
    public Transform handle;
    private Lamp lamp;
    public AudioSource leverPull;
    public AudioSource staticNoise;
    public AudioLowPassFilter filter;

    void Start()
    {
        electricalSwitchOn = true;
        for (int i = 0; i < BigLights.Length; i++)
        {
            BigLights[i].enabled = electricalSwitchOn;
        }
    }

   public void ClickElectricalbox()
    {
        if (isAnim)
            return;

        StartCoroutine(HandleLightAnimation(electricalSwitchOn));
    }
    
    IEnumerator HandleLightAnimation(bool on)
    {
        isAnim = true;

        electricalSwitchOn = !electricalSwitchOn;

        for (int i = 0; i < BigLights.Length; i++)
        {
            BigLights[i].enabled = electricalSwitchOn;
        }
        lamp = FindObjectOfType<Lamp>();
        lamp.CheckLampCap();
        staticNoise.enabled = electricalSwitchOn;
        filter.enabled = !electricalSwitchOn;
        leverPull.Play();

        if (on)
        {
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -5);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -20);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -40);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -60);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -80);
            yield return new WaitForSeconds(0.1f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -100);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -120);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -140);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -160);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -180);
        }
        else
        {
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -180);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -160);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -140);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -120);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -100);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -80);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -60);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -40);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -20);
            yield return new WaitForSeconds(0.05f);
            handle.rotation = Quaternion.Euler(handle.rotation.x, -90, -5);
        }

        isAnim = false;
        yield return null;
    }
}
