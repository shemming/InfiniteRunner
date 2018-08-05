using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSize;

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        var newPosition = Mathf.Repeat( Time.time * scrollSpeed, tileSize );
        transform.position = startPosition + Vector3.left * newPosition;
    }
}