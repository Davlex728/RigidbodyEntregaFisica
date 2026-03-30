using UnityEngine;

public class Ej4 : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad = 5f;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(h, 0f, v).normalized * velocidad;
        rb.linearVelocity = new Vector3(mov.x, rb.linearVelocity.y, mov.z);
    }
}