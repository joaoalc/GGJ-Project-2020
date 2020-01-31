using UnityEngine;
using System.Collections;


public class MovementManager : MonoBehaviour
{
    public enum type { platformer, topDown };
    public type moveType;
    public float moveSpeed, jumpHeight;
    public bool onGround = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }

        if (moveType == type.platformer && Input.GetAxisRaw("Vertical") > 0 && onGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D (Collision2D obj)
    {
        if (obj.gameObject.tag == "ground")
        {
            onGround = true;
        }
    }

    void OnCollisionExit2D (Collision2D obj)
    {
        if (obj.gameObject.tag == "ground")
        {
            onGround = false;
        }
    }
}