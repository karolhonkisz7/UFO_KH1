using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
    public Image heart_01;
    public Image heart_02;
    public Image heart_03;

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("UFO") && heart_01.gameObject.activeSelf == true)
        {
            heart_01.gameObject.SetActive(false);
        }
        else if (heart_01.gameObject.activeSelf == false && heart_02.gameObject.activeSelf == true)
        {
            heart_02.gameObject.SetActive(false);
        }
        else if (heart_01.gameObject.activeSelf == false && heart_02.gameObject.activeSelf == false)
        {
            heart_03.gameObject.SetActive(false);
        }
    }
}

