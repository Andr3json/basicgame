using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    int x = -7;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z-x).ToString("0");

    }
}
