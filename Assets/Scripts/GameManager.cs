using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 0.5f;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded==false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            Debug.Log("Game Over!");
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
