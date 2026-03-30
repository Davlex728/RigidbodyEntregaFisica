using UnityEngine;

public class Ej6 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaAceleracion = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(h, 0f, v);
        rb.AddForce(direccion * fuerzaAceleracion, ForceMode.Acceleration);
    }
}