using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;

    public float restartDelay = 1f;
    
    public void EndGame()
    {
        if (!_gameHasEnded)
        {
            _gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
