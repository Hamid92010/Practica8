using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPelota : MonoBehaviour
{
    public GameObject pelotas;
    public Transform posicionInicial;
    public int instancia;

    // Start is called before the first frame update
    void Start()
    {
        instancia = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && instancia == 0)
        {
            Instantiate(pelotas, posicionInicial);
            Debug.Log("Se instancio una pelota");

            instancia = 1;
        }
    }

    public void ModificarVariable(int nuevoValor)
    {
        instancia = nuevoValor;
    }
}
