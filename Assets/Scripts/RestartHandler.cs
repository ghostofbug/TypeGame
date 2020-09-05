using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text DisplayScore;
    public Text DisplayHighScore;
    public GameManagement gameManagment;
    public void RestartButton()
    {
        FindObjectOfType<AudioManager>().PlayAudio("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenuButton()
    {
        FindObjectOfType<AudioManager>().PlayAudio("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    private void OnEnable()
    {
        DisplayScore.text = gameManagment.Score.ToString();
        DisplayHighScore.text= PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
