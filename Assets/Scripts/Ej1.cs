using UnityEngine;

public class Ej1 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerza = 10f;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
    }
}