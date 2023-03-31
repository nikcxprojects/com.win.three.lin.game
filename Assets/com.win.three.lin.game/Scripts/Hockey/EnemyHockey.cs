using UnityEngine;

public class EnemyHockey : MonoBehaviour
{
    private Transform Ball { get; set; }
    private Rigidbody2D Rigidbody { get; set; }

    private void Awake()
    {
        Ball = GameObject.Find("ballHockey").transform;
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var newPos = new Vector2(Ball.position.x, 2.363f);
        Rigidbody.MovePosition(newPos);
    }
}
