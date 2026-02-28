using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Call this method to reset the scene
    public void ResetScene()
    {
        // Reload the current scene to reset everything
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Press 'R' to reset the scene
        {
            ResetScene();
        }
    }
}