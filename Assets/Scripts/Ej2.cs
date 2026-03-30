using UnityEngine;

public class Ej2 : MonoBehaviour
{

    Rigidbody rb;
    public float fuerza = 10f;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0f, v) * fuerza, ForceMode.Force);
    }

}
