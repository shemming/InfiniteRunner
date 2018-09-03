using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour {

    public Text scoreDisplay;
    public Text highScoreMessage;

    // Use this for initialization
    private void Start()
    {
        scoreDisplay.text = ApplicationModel.Instance.score.ToString();

        // if high score was beaten, save new high score
        int score = int.Parse( scoreDisplay.text );
        var highScore = PlayerPrefs.GetInt( "highscore" );
        if ( highScore < score ) {
            PlayerPrefs.SetInt( "highscore", score );
            highScoreMessage.gameObject.SetActive( true );
        }
    }
}
