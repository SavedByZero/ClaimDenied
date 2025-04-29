using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // This gets the horizontal movement (when you press the right or left arrow keys, or the a or d keys)
        float moveX = Input.GetAxis("Horizontal");  // This value will be from left to right, where -1 is fully left and 1 is fully right
        
        //This gets the vertical movement (when you press the up or down arrow keys, or the w or s keys)
        float moveY = Input.GetAxis("Vertical");    // This value will be from -1 to 1 , where -1 is fully down and 1 is fully up

        // Move the player by directly changing its position 
        transform.Translate(new Vector3(moveX * Speed * Time.deltaTime, moveY * Speed * Time.deltaTime, 0));
    }
}

