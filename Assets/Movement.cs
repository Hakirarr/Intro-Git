using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody rb;
    [SerializeField] private bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        // Déplacement horizontal et vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcul de la direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;

        // Applique la force de déplacement
        Vector3 newPosition = rb.position + movement * Time.deltaTime;
        rb.MovePosition(newPosition);
    }
}
