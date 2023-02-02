using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    [SerializeField]
    private Game_Manager gameManager;

    void OnTriggerEnter(Collider triggerinfo)
    {
        if (triggerinfo.GetComponent<PlayerCollision>())
        {
           gameManager.CompleteLevel();
        }
    }
}