using UnityEngine;

public class CatchPlayer : MonoBehaviour
{
    private void Update()
    {
        var _pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButton(0))
        {
            transform.position = new Vector2(_pos.x, transform.position.y);
        }
    }
}
