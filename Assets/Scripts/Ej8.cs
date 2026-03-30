using UnityEngine;

public class Ej8 : MonoBehaviour
{
    public float fuerzaExplosion = 500f;
    public float radioExplosion = 5f;
    public float upwardsModifier = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Explotar();
    }

    void Explotar()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radioExplosion);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddExplosionForce(fuerzaExplosion, explosionPos, radioExplosion, upwardsModifier, ForceMode.Force);
        }
    }
}