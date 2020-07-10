using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{


    public bool isActive;

    private void Update()
    {
        if (isActive == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();
        }
    }

    void Restart()
    {
        Time.timeScale = 1;
        Scene myScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
