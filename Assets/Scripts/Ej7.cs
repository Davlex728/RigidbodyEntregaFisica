using UnityEngine;

public class Ej7 : MonoBehaviour
{
    Rigidbody rb;
    public float fuerzaTorque = 10f;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddTorque(Vector3.up * -fuerzaTorque, ForceMode.Force);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddTorque(Vector3.up * fuerzaTorque, ForceMode.Force);
    }
}