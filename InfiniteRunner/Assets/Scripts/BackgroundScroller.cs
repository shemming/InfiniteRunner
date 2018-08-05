using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Debug.Log( startPosition.ToString() );
    }

    void Update()
    {
        var newPosition = Mathf.Repeat( Time.time * scrollSpeed, tileSizeZ );
        transform.position = startPosition + Vector3.left * newPosition;
    }
}