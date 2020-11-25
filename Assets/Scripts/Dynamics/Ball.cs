using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Fix());
    }

    IEnumerator Fix()
    {
        transform.position = new Vector3(transform.position.x - 0.001f, transform.position.y, transform.position.z);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Fix());
    }
}
