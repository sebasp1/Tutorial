using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintMultipler = 2.0f;



    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // flechas izquierda/derecha
        float moveZ = Input.GetAxis("Vertical");   // flechas arriba/abajo
        float currentSpeed = speed;



        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            currentSpeed *= sprintMultipler;
        }

        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}