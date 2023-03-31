using System.Collections;
using UnityEngine;

public class CatchGame : MonoBehaviour
{
    private GameObject ballPrefab;

    private void Awake()
    {
        ballPrefab = Resources.Load<GameObject>("ballcatch");
    }

    private void OnEnable()
    {
        StartCoroutine(nameof(Spawning));
    }

    private void OnDestroy()
    {
        StopCoroutine(nameof(Spawning));
    }

    private IEnumerator Spawning()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1.2f));
            Instantiate(ballPrefab, transform);
        }
    }
}
