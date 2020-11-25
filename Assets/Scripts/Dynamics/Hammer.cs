using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject hammer;
    private bool hasHammer = false;
    public GameObject electricalboxGlass;
    public AudioSource glassBreak;
    void Start()
    {
        
    }

    public void GetHammer()
    {
        Transform hand = GameObject.Find("Hand").transform;
        hammer.transform.parent = hand.transform;
        hammer.transform.position = hand.transform.position;
        hammer.transform.rotation = hand.transform.rotation;
        hasHammer = true;
    }

    public void BreakGlassWithHammer()
    {
        if(hasHammer)
        {
            Destroy(electricalboxGlass);
            glassBreak.Play();
            Destroy(hammer);
        }
    }
}
