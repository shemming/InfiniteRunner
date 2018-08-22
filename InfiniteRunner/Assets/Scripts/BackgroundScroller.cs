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
        var distance = transform.position.x < 0 ? transform.position.x * -1 : transform.position.x;
        if (distance > tileSize) {
            transform.position = startPosition;
        }

        transform.position = transform.position + Vector3.left * (scrollSpeed / 100);

    }
}