using System;
using System.Threading;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public float rotationSpeed = 60.0f; // Prêdkoœæ obrotu

    private void Update()
    {
        // Obracaj obiekt w kó³ko
        transform.Rotate(new Vector3(0,0,45) * Time.deltaTime);
    }
}
