using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //[SerializeField] private Texture2D cursorTexture;
    public Texture2D cursorTexture;

    void Start()
    {
        // An idea to change the cursor... maybe later on
        //Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
    
    void Update()
    {
        bool escPressed = Input.GetKey(KeyCode.Escape);
        if (escPressed)
        {
            if (SceneManager.GetActiveScene().name == "StartMenu2")
                QuitGame();
            else
                LoadScene("StartMenu2");
        }
    }

    public void LoadScene(string name){
        SceneManager.LoadScene(name);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
