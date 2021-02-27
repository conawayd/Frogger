using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject livesManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && rb.position.x <= 6)
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && rb.position.x >= -6)
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        if (Input.GetKeyDown(KeyCode.DownArrow) && rb.position.y >= -4)
            rb.MovePosition(rb.position + Vector2.down);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("WE LOST!");
            rb.transform.position = new Vector2(0, -4);
            //Score.CurrentScore = 0;

            livesManager.GetComponent<LivesManager>().ReduceLife();
        }
    }
}
