using UnityEngine;

public class PlayerMovementWithPhysics : MonoBehaviour
{
    public float Speed = 5f;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        // This gets the horizontal movement (when you press the right or left arrow keys, or the a or d keys)
        float moveX = Input.GetAxis("Horizontal");  // This value will be from left to right, where -1 is fully left and 1 is fully right

        //This gets the vertical movement (when you press the up or down arrow keys, or the w or s keys)
        float moveY = Input.GetAxis("Vertical");    // This value will be from -1 to 1 , where -1 is fully down and 1 is fully up

        // Set the velocity of the Rigidbody2D to move the player
        _rb.linearVelocity = new Vector2(moveX * Speed, moveY * Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ouch! You hit me, " + collision.gameObject);      
    }
}

