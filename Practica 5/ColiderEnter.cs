using UnityEngine;

public class ColiderEnter : MonoBehaviour
{
    // Este color se aplicará cuando el Jugador toque la Placa
    public Color newColor = Color.black;
    

    // Se llama cuando colisiona con otro objeto
    public void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto con el que colisiona es la Placa (usando su nombre)
        if (collision.gameObject.CompareTag("Placa"))
        {
            // Cambia el color del Jugador
            GetComponent<Renderer>().material.color = newColor;
        }
    }
}
