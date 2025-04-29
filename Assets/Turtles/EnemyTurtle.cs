using UnityEngine;

public class EnemyTurtle : MonoBehaviour
{
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ouch! YOU hit ME, " + collision.gameObject);
        //_rb.linearVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
