using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultDoor : MonoBehaviour
{
    public TextMesh vaultdoorText;
    public string input;
    public AudioSource beep;
    private Crayon crayon;
    public GameObject fadeOut;

    void Start()
    {
        fadeOut.SetActive(false);
        crayon = FindObjectOfType<Crayon>();
        input = "";
        vaultdoorText.text = input;
    }

    public void PressNumber(int keyInputNumber)
    {
        beep.pitch = 1;
        beep.Play();
        if (input.Length == 4)
        {
            return;
        }
        input += keyInputNumber.ToString();
        vaultdoorText.text = input;
    }

    public void Clear()
    {
        beep.pitch = 0.7f;
        beep.Play();
        input = "";
        vaultdoorText.text = input;
    }

    public void Submit()
    {
        if (input == "58" + crayon.boardText.text + "4")
        {
            beep.pitch = 1.2f;
            beep.Play();
            Win();
            fadeOut.SetActive(true);
        }
        else
        {
            Clear();
        }
    }

    void Win()
    {
    Debug.Log("Win");
    }
}
