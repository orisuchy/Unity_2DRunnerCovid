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
        Cursor.SetCursor(cursorTexture, new Vector2(0, 0), CursorMode.Auto);
    }

    public void LoadScene(string name){
        SceneManager.LoadScene(name);
    }
}
