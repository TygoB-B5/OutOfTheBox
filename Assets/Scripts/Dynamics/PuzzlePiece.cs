using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public GameObject puzzlePiece;
    public GameObject finishPiece;
    private bool hasPiece = false;
    private ReflectionProbe refl;
    public AudioSource puzzleSound;

    void Start()
    {
        finishPiece.SetActive(false);
        refl = FindObjectOfType<ReflectionProbe>();
    }

    public void GetPiece()
    {
        Transform hand = GameObject.Find("Hand").transform;
        puzzlePiece.transform.parent = hand.transform;
        puzzlePiece.transform.position = hand.transform.position;
        puzzlePiece.transform.rotation = hand.transform.rotation;
        puzzleSound.pitch = 1;
        puzzleSound.Play();
        hasPiece = true;
    }

    public void FinishPiece()
    {
        if(hasPiece)
        {
            Destroy(puzzlePiece);
            finishPiece.SetActive(true);
            refl.RenderProbe();
            puzzleSound.pitch = 1;
            puzzleSound.Play();
            hasPiece = false;
        }
    }
}
