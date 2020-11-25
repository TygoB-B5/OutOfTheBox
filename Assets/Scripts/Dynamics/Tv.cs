using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv : MonoBehaviour
{
    public GameObject tvScreen;
    public bool tvScreenOn;
    void Start()
    {
        tvScreen.SetActive(false);
    }

    public void ClickTvButton()
    {
        tvScreenOn = !tvScreenOn;
        tvScreen.SetActive(tvScreenOn);
    }
}
