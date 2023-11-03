using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Dodaj to, aby u¿ywaæ komponentu Text

public class UFOmovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float force; // Zmieñ na float
    public Text score; // Zmieni³em z "text" na "Text"
    public Text winText; // Zmieni³em z "text" na "Text"
    float count = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * force);
    }

    private void OnTriggerEnter2D(Collider2D obiekt)
    {
        if (obiekt.gameObject.CompareTag("Pickup"))
        {
            Destroy(obiekt.gameObject);
            count++;
            UpdateText();
        }
    }

    void UpdateText()
    {
        score.text = "Score: " + count.ToString(); // Wyœwietl wynik w formie "Score: X"
        if (count == 6)
        {
            winText.gameObject.SetActive(true);
        }
    }
}