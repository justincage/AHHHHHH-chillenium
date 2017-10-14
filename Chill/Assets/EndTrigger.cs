using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public FezManager fezManager;

    public void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}