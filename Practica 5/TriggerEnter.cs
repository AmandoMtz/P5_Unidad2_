using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    [SerializeField] public Transform LinkedPortal; // El otro portal al que se teletransportará el objeto

    // Detecta cuando el cubo entra en el área de trigger del portal
    public void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Cubo"))
    {
        if (LinkedPortal != null)
        {
            Debug.Log("Teletransportando al cubo...");
            other.transform.position = LinkedPortal.position;
            other.transform.rotation = LinkedPortal.rotation;
        }
    }
}

}