using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 100f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            var position = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
            rb.MovePosition(position);
        }
    }
}