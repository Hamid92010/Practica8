using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoPelota : MonoBehaviour
{
    public ControlPelota controlPelota;
    public int valorPelota;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Pierde")
        {
            Destroy(this.gameObject);
            Debug.Log("Se destruyo pelota");

            valorPelota = 0;
            controlPelota.ModificarVariable(valorPelota);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        controlPelota = FindObjectOfType<ControlPelota>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    public void OnTriggerEnter(Collider other)
    {
        if (other.collider.name == "Pierde")
        {
            Destroy(this.gameObject);
        }
    }
    */
}
