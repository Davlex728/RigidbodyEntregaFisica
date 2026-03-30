using UnityEngine;

public class Ej3 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaAceleracion = 1000f;
    public float fuerzaFrenado = 500f;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * fuerzaAceleracion, ForceMode.Force);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(-transform.forward * fuerzaFrenado, ForceMode.Force);
    }
}