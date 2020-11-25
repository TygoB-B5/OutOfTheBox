using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crayon : MonoBehaviour
{
    public GameObject crayon;
    public TextMesh boardText;
    private Vector3 oldpos;
    private Quaternion oldrot;
    private bool hasCrayon = false;
    private int boardNumber = 0;
    public AudioSource crayonSwipe;
    void Start()
    {
        oldpos = crayon.transform.position;
        oldrot = crayon.transform.rotation;
        boardText.text = boardNumber.ToString();
    }

    public void GetCrayon()
    {
        Transform hand = GameObject.Find("Hand").transform;
        crayon.transform.parent = hand.transform;
        crayon.transform.position = hand.transform.position;
        crayon.transform.rotation = hand.transform.rotation;
        hasCrayon = true;
        crayonSwipe.pitch = 0.70f;
        crayonSwipe.Play();
    }

    public void ChangeNumber()
    {
        if(hasCrayon)
        {
            if (boardNumber >= 9)
            {
                boardNumber = -1;
            }

            boardNumber += 1;
            boardText.text = boardNumber.ToString();
            crayonSwipe.pitch = 1;
            crayonSwipe.Play();
        }
    }

    public void LayDownCrayon()
    {
        if (hasCrayon)
        {
            crayon.transform.parent = GameObject.Find("Dynamics").transform;
            crayon.transform.position = oldpos;
            crayon.transform.rotation = oldrot;
            hasCrayon = false;
            crayonSwipe.pitch = 0.70f;
            crayonSwipe.Play();
        }
    }
}