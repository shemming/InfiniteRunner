using UnityEngine;

public class ObstacleRolling : MonoBehaviour
{

    public float scrollSpeed;

    void Awake()
    {
        ResetObstacle(transform.localPosition.x);
    }

    void Update()
    {
        transform.localPosition = transform.localPosition + Vector3.left * (scrollSpeed/100);
    }

    void OnTriggerEnter2D( Collider2D col )
    {
        if ( col.gameObject.tag == "StopObstacle" )
        {
            ResetObstacle(14);
        }
        else if (col.gameObject.tag == "Player") {
            Debug.Log("Game Over");
        }
    }

    void ResetObstacle(float xPos) {
        transform.localPosition = new Vector3( xPos, Random.Range( -3f, -.5f ) );
    }
}