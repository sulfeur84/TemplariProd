
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScipte : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2") || other.CompareTag("Player3") ||
            other.CompareTag("Player4"))
        {
            FindObjectOfType<AudioManager>().Play("WIN");
            FindObjectOfType<AudioManager>().Stop("Game");

            SceneManager.LoadScene("Victory");
        }
    }
}
