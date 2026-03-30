using UnityEngine;

public class Ej5 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaAceleracion = 1000f;
    public float dragNormal = 0.5f;
    public float dragFrenado = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearDamping = dragNormal;

        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearDamping = dragNormal;
            rb.AddForce(transform.forward * fuerzaAceleracion, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.S))
        {

            rb.linearDamping = dragFrenado;
        }
        else
        {
            rb.linearDamping = dragNormal;
        }
    }
}