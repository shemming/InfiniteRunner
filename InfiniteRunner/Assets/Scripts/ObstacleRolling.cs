using UnityEngine;

public class ObstacleRolling : MonoBehaviour
{

    void Awake()
    {
        ResetObstacle(transform.localPosition.x);
    }

    void Update()
    {
        transform.localPosition = transform.localPosition + Vector3.left * .085f;
    }

    void OnTriggerEnter2D( Collider2D col )
    {
        if ( col.gameObject.tag == "StopObstacle" )
        {
            ResetObstacle(14);
        }
    }

    void ResetObstacle(float xPos) {
        transform.localPosition = new Vector3( xPos, Random.Range( -3f, -.5f ) );
    }
}