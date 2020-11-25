using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tack : MonoBehaviour
{
    public GameObject tack;
    private bool hasTack = false;

    private Vector3 oldTackPos;
    public GameObject newTack;
    public AudioSource tackClick;

    void Start()
    {
        oldTackPos = tack.transform.position;
        newTack.SetActive(false);
    }
    public void GetTack()
    {
        Transform hand = GameObject.Find("Hand").transform;
        tack.transform.parent = hand.transform;
        tack.transform.position = hand.transform.position;
        tack.transform.rotation = hand.transform.rotation;
        hasTack = true;
        tackClick.Play();
    }

    public void PlaceTack()
    {
        if (hasTack)
        {
            Physics.gravity = new Vector3(0, -Physics.gravity.y, 0);
            tackClick.Play();
            tack.transform.parent = GameObject.Find("Dynamics").transform.parent;
            tack.SetActive(false);
            newTack.SetActive(true);
            hasTack = false;
        }
    }
    public void ResetTack()
    {
        Physics.gravity = new Vector3(0, -Physics.gravity.y, 0);
        tackClick.Play();
        tack.SetActive(true);
        tack.transform.position = oldTackPos;
        tack.transform.parent = GameObject.Find("Dynamics").transform.parent;
        newTack.SetActive(false);
    }

}
