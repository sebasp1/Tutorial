using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // flechas izquierda/derecha
        float moveZ = Input.GetAxis("Vertical");   // flechas arriba/abajo

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized;

        transform.Translate(movement * speed * Time.deltaTime);
    }
}