using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject door;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            door.GetComponent<Door>().OpenOrClose();
        }
    }
}
