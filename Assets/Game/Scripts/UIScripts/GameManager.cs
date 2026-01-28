using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool IsMenuOpened = false;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsMenuOpened)
                LoadScene();
            else
                CloseMenu();
        }
    }

    

    void CloseMenu()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        IsMenuOpened = false;
        Time.timeScale = 1f;        // Resume game
        AudioListener.pause = false;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("End");
    }
}
