using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // El objeto que se va a seguir
    public Transform player; 
    
    // Velocidad a la que el objeto seguirá al jugador
    public float followSpeed = 2f; 
    
    // Distancia mínima permitida entre el objeto y el jugador
    public float minDistance = 1f; 
    
    // Distancia máxima permitida entre el objeto y el jugador
    public float maxDistance = 10f;
    
    // Variable para almacenar la posición Y original del objeto
    private float originalY;

    void Start()
    {
        // Almacena la posición Y original del objeto al inicio
        originalY = transform.position.y;
    }

    void Update()
    {
        // Comprueba la distancia entre el objeto y el jugador
        float distance = Vector3.Distance(transform.position, player.position);

        // Si la distancia está dentro del rango especificado, mueve el objeto hacia el jugador
        if (distance > minDistance && distance < maxDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            // Calcula la nueva posición manteniendo la posición Y original
            Vector3 newPosition = transform.position + direction * followSpeed * Time.deltaTime;
            newPosition.y = originalY;

            // Actualiza la posición del objeto
            transform.position = newPosition;

            // Hacer que el objeto mire hacia el jugador, manteniendo la posición Y original
            Vector3 lookDirection = player.position - transform.position;
            lookDirection.y = 0; // Ignora el eje Y para evitar que el objeto se incline
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}
