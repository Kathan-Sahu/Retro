using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuChanges : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameOverMenu;
    public GameObject finishMenu;
    private GameObject player;
    public void WeQuit()
    {
        Debug.Log("Application is quit");
        Application.Quit();
    }

    public void Restart()
    {
        Debug.Log("restart the game");
        mainMenu.SetActive(true);
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        Debug.Log("Go to main menu");
        gameOverMenu.SetActive(false);
        mainMenu.SetActive(true);

    }

    public void StartMain()
    {
        Debug.Log("Go to Game");
        mainMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            finishMenu.SetActive(true);
        }
    }
}
