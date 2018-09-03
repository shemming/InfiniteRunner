using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {


    public void StartGame() {
        ApplicationModel.Instance.score = 0;
        SceneManager.LoadScene( "Main", LoadSceneMode.Single );
    }


}
