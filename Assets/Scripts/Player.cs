using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_Rigidbody;

    [SerializeField] private float spinningSpeed;

    private void FixedUpdate()
    {
        m_Rigidbody.rotation += spinningSpeed;

        if (Input.GetAxis("Horizontal") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(10, 0));
        }

        if(Input.GetAxis("Horizontal") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(-10, 0));
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, 10));
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            m_Rigidbody.AddForce(new Vector2(0, -10));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag != "Button")
        {
            transform.position = Vector3.zero;
        }
    }
}
