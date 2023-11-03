using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject player; //zmienna   z informacjami o jaki obiekt chodzi
    Vector3 offset; //zmienna przechowuje kordynaty w osiach x,y i z 


    void Start()
    {
        offset = transform.position - player.transform.position;  // obliczamy odst�p pomi�dzy od playera przez x y i z  
    }

    
    void Update()
    {
        transform.position = offset + player.transform.position; // obliczamy pozycje kamery za pomoc� pobierania aktualnej pozycji  gracza w przestrzeni 
         // dodaj�c   do tego za ka�dym razem
    }
}
