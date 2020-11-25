using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : MonoBehaviour
{
    public GameObject antenna;
    private bool hasAntenna = false;
    public GameObject tvOutsideScreen;
    public GameObject tvScreen;
    public GameObject newAntenna;
    public AudioSource antennaSound;

    void Start()
    {
        tvOutsideScreen.SetActive(false);
        newAntenna.SetActive(false);
    }

    public void GetAntenna()
    {
        Transform hand = GameObject.Find("Hand").transform;
        antenna.transform.parent = hand.transform;
        antenna.transform.position = hand.transform.position;
        antenna.transform.rotation = hand.transform.rotation;
        antennaSound.pitch = 0.6f;
        antennaSound.Play();
        hasAntenna = true;
    }

    public void PlaceAntenna()
    {
        if (hasAntenna)
        {
            antennaSound.pitch = 0.6f;
            antennaSound.Play();
            hasAntenna = false;
            Destroy(antenna);
            tvOutsideScreen.SetActive(true);
            tvOutsideScreen.transform.parent = tvScreen.transform;
            newAntenna.SetActive(true);
        }
    }
}
