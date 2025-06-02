using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed = 5f;
    Vector2 Movement;
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * Speed * Time.deltaTime);
    }
}
