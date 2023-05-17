using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalNivelPelota : MonoBehaviour
{

    // Array de colores a usar
    public Color[] colors;

    //Variable de control de cambio de color 
    public int ent = 0;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pelota"))
        {
            ent = ent + 1;

            if (ent > 2)
            {
                ent = 0;
            }

            Debug.Log("La pelota entró en el trigger.");
            Renderer renderer = other.GetComponent<Renderer>();

            // Seleccionar un color aleatorio del array de colores
            Color newColor = colors[ent];
            renderer.material.color = newColor;
        }
    }
}
