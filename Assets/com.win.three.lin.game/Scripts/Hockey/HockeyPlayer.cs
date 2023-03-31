using UnityEngine;

public class HockeyPlayer : MonoBehaviour
{
    private Vector2 _position;
    private Rigidbody2D Rigidbody { get; set; }

    private void Awake()
    {
        _position = transform.position;
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        _position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Rigidbody.MovePosition(_position);
    }
}
