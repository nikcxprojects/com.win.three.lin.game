using UnityEngine;

public class CatchBall : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector2(Random.Range(1.5f, .5f), -5.8f);
        Destroy(gameObject, 6.0f);
    }

    private void Update()
    {
        transform.Translate(3.0f * Time.deltaTime * Vector2.up);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(SettingsManager.VibraEnable)
        {
            Handheld.Vibrate();
        }

        Destroy(gameObject);
    }
}
