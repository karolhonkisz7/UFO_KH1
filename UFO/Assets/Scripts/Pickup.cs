using System;
using System.Threading;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public float rotationSpeed = 60.0f; // Pr�dko�� obrotu

    private void Update()
    {
        // Obracaj obiekt w k�ko
        transform.Rotate(new Vector3(0,0,45) * Time.deltaTime);
    }
}
