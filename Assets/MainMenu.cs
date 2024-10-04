using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public void ExitGame()
    {
        Debug.Log("Выходим");
        Application.Quit();
    }
}
