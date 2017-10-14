using UnityEngine;
using UnityStandardAssets.Cameras;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        Debug.Log("GAME OVER");
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Completed");

        completeLevelUI.SetActive(true);
    }
	
}
