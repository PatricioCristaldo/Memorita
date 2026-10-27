using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [Tooltip("La cámara de la habitación de la que sale el jugador")]
    public GameObject camaraActual;
    
    [Tooltip("La cámara de la habitación a la que entra el jugador")]
    public GameObject camaraSiguiente;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que cruzó la puerta es el jugador
        if (collision.CompareTag("Player"))
        {
            camaraActual.SetActive(false);
            camaraSiguiente.SetActive(true);
        }
    }
}