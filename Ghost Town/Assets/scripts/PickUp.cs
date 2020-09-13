using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Collider jackCollision;

    private bool hasCollided = false;

    void Start()
    {
        jackCollision = GetComponent<Collider>();
    }

    //Comprobar si ha colisionado
    private void OnTriggerEnter(Collider keyCollision)
    {
        if (!hasCollided && keyCollision.gameObject.tag == "Player")
        {
            hasCollided = true;
        }
    }

    private void OnTriggerStay(Collider keyCollision)
    {
        if (keyCollision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);
        }
    }

    //Si ha colisionado, mostrar mensaje y desactivar item
    private void OnGUI()
    {
        if (hasCollided == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "PRESS E");
        }
    }

    //Desactivar GUI si no hay colisión
    private void OnTriggerExit(Collider collision)
    {
        hasCollided = false;
        GUI.enabled = false;
    }
}
