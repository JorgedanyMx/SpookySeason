using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;       // Velocidad de movimiento
    public float rotationSpeed = 10f;  // Velocidad de giro (mayor = más rápido)

    void Update()
    {
        // Leer input
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Vector de movimiento
        Vector3 direction = new Vector3(moveX, 0f, moveZ).normalized;

        // Si hay movimiento...
        if (direction.magnitude >= 0.1f)
        {
            // Calcular ángulo de rotación objetivo
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

            // Crear rotación suave hacia el objetivo
            Quaternion targetRotation = Quaternion.Euler(0f, targetAngle, 0f);

            // Aplicar rotación interpolada
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Mover hacia adelante en la dirección actual (ya rotada)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
