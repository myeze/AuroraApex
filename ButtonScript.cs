using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    EditorSceneManager sm;
    public void LoadPlayScene0()
    {
        EditorSceneManager.LoadScene(0);
    }
    public void LoadPlayScene1()
    {
        EditorSceneManager.LoadScene(1);
    }

    public void LoadPlayScene2()
    {
        EditorSceneManager.LoadScene(2);
    }

    public void LoadPlayScene3()
    {
        EditorSceneManager.LoadScene(3);
    }

    public void LoadPlayScene4()
    {
        EditorSceneManager.LoadScene(4);
    }

    public void LoadPlayScene5()
    {
        EditorSceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
