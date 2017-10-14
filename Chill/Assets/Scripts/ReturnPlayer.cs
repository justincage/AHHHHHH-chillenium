using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnPlayer : MonoBehaviour
{

    public Transform ReturnPoint;


    public void OnTriggerEnter(Collider other)
    {

        //other.transform.position = ReturnPoint.position;

        FindObjectOfType<GameManager>().EndGame();
        Restart();
       // FindObjectOfType<FezManager>().ReturnToStart(); 

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DynamicGI.UpdateEnvironment();
    }
}