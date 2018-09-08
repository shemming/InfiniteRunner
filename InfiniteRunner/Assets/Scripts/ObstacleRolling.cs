using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObstacleRolling : MonoBehaviour
{

    public float scrollSpeed;
    public Text scoreDisplay;


    private void Start()
    {
        ResetObstacle( transform.localPosition.x );
        int.Parse( scoreDisplay.text );
    }

    void Update()
    {
        transform.localPosition = transform.localPosition + Vector3.left * (scrollSpeed/100);
    }

    void OnTriggerEnter2D( Collider2D col )
    {
        switch ( col.gameObject.tag )
        {
            case "StopObstacle":
                ResetObstacle( 14 );
                break;
            case "Score":
                ApplicationModel.Instance.score += 1;
                scoreDisplay.text = ApplicationModel.Instance.score.ToString();
                break;
            case "Player":
                SceneManager.LoadScene( "GameOver", LoadSceneMode.Single );
                break;
        }
    }

    void ResetObstacle(float xPos) {
        transform.localPosition = new Vector3( xPos, Random.Range( -3f, -.5f ) );
    }
}