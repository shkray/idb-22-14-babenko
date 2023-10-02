using UnityEngine;

public class PushBall : MonoBehaviour
{
    public float force = 10.0f; // Сила толчка

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Применяем силу к Rigidbody для толчка шарика
            Vector3 pushDirection = Vector3.forward; // Направление толчка
            rb.AddForce(pushDirection * force, ForceMode.Impulse);
        }
    }
}