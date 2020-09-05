using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayButton;
    public Animator PlayButtonTransition;
    public Animator GameTitleTransition;
    public Animator CountDownTransition;
 
    public Animator VolumeButtonAnimation;
    private Button playButton;
    private bool ClickedForSync;
    public Sprite VolumeUp;
    public Sprite VolumeMute;
    public Image VolumeButton;
    void Start()
    {
        ClickedForSync = false;
        PlayButtonTransition = PlayButton.GetComponent<Animator>();
        playButton = PlayButton.GetComponent<Button>();
        if (PlayerPrefs.GetInt("Volume") == 0)
        {
            FindObjectOfType<AudioManager>().NonMuteSound();
            VolumeButton.sprite = VolumeUp;
            
        }
        else
        {
            FindObjectOfType<AudioManager>().MuteSound();
            VolumeButton.sprite = VolumeMute;
      
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void OnOffSound()
    {
      
        if (PlayerPrefs.GetInt("Volume")==0)
        {
          
            PlayerPrefs.SetInt("Volume", 1);
            VolumeButton.sprite = VolumeMute;
            Debug.Log(PlayerPrefs.GetInt("Volume"));
          //  FindObjectOfType<AudioManager>().MuteSound();
          //  Camera.main.GetComponent<AudioListener>().enabled = !Camera.main.GetComponent<AudioListener>();
         //   AudioListener.volume = 0;
        }
        else
        {
            FindObjectOfType<AudioManager>().PlayAudio("Button");
            PlayerPrefs.SetInt("Volume", 0);
            VolumeButton.sprite = VolumeUp;
            Debug.Log(PlayerPrefs.GetInt("Volume"));
            //     FindObjectOfType<AudioManager>().NonMuteSound();
            //    Camera.main.GetComponent<AudioListener>().enabled = Camera.main.GetComponent<AudioListener>();
            //  AudioListener.volume = 1;
        }
      
    }
    public void playGame()
    {
        ClickedForSync = true;
        FindObjectOfType<AudioManager>().PlayAudio("Button");
        StartCoroutine(PlayGame());
    }
    public bool GetClickedForSynce()
    {
        return ClickedForSync;
    }
    IEnumerator PlayGame()
    {
        playButton.interactable = false;
        VolumeButtonAnimation.SetTrigger("PlayGame");
        GameTitleTransition.SetTrigger("Transition");
        CountDownTransition.SetTrigger("CountDownIn");
       
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
