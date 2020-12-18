using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
