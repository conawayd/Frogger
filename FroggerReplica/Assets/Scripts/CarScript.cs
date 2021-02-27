using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    public float speed = 1f;

    public float deathTimer = 2;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed) * GameManager.carSpeed;
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

        if (deathTimer > 0)
        {
            deathTimer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
