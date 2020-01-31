using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;
    public bool jumpAllowed;
    Rigidbody2D rb;

    float base_gravity_scale = 3;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

        


        if (Input.GetKeyDown(KeyCode.Space) && jumpAllowed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            jumpAllowed = false;
        }
        else if(!Input.GetKey(KeyCode.Space) && !jumpAllowed)
        {

            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale * 2.75f;
        }
        if (!jumpAllowed && rb.velocity.y < -0.001f)
        {
            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale * 2f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else rb.velocity = new Vector2(0, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale;
            jumpAllowed = true;
        }
    }
}
