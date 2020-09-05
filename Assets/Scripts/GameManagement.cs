using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    // Start is called before the first frame update


    private bool PlaySoundLosing;

    public RuntimeAnimatorController TutorialAnimator;
    public RuntimeAnimatorController DefaultAnimator;

    public Animator TextAnimation;
    
   
    public SetTimer timer;
    public MixPosition mixPos;
    public RandomString randomString;

    public int Score;
    private bool EndGame;
    public Text DisplayScore;

    public bool ReloadTimer;

    public GameObject RestartPanel;
   
    public SetUpCountDownAnimation setUpCountDown;
    public GameObject HighScoreCongrat;

    public AudioManager audioManager;
    private void UpdateScore()
    {
        Score++;
        Animator ScoreIncreaseAnimator;
        ScoreIncreaseAnimator = DisplayScore.GetComponent<Animator>();
        ScoreIncreaseAnimator.SetTrigger("ScoreUpdate");
        DisplayScore.text = Score.ToString();
    }
    private void UpdateHighScore()
    {
        if (Score>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }
    void DecayMaxTimer()
    {
        if (Score % 7 == 0 && Score!=0)
        {
            timer.timeMax = timer.timeMax - 0.01f;
            if (timer.timeMax <= 1.9f)
            {
                timer.timeMax = 1.9f;
            }
        }
    }

    public bool CheckAlphabet(string buttonname)
    {
        if (RandomString.RandomWord!=null)
        {
            if (buttonname == RandomString.OrderWord[GameControl.TapCount].ToString())
            {
                randomString.UpdateColorText();
                return true;
            }
            else
            {
               
               // InputUser3Word = InputUser3Word.Remove(GameControl.TapCount);
                return false;
            }
        }
        return false;
    }
    public void GenerateWord()
    {
        GameControl.TapCount = 0;
      
    
    }


    private void Start()
    {
        Score = 0;
        ReloadTimer = false;
        RestartPanel.SetActive(false);
        EndGame = false;
        HighScoreCongrat.SetActive(false);
        audioManager = FindObjectOfType<AudioManager>();
        TextAnimation.runtimeAnimatorController = DefaultAnimator;
        
        if (PlayerPrefs.GetInt("Tutorial") == 0)
        {
               
                
            
        }
        else
        {
          
            timer.StopClockCountDown();
            GenerateWord();
            randomString.GenerateRandomWord();
            mixPos.GenerateRandomPositionString();
            timer.CountinueClockCountDown();
          
            PlaySoundLosing = false;
        }
    }
    void NextRound()
    {



        randomString.GenerateRandomWord();
        mixPos.GenerateRandomPositionString();
        TextAnimation.SetTrigger("ReadyNextWord");
      
     

    }

    void DelayTime()
    {
        TextAnimation.runtimeAnimatorController = DefaultAnimator;
        timer.CountinueClockCountDown();
    }
    public void ForTutorial()
    {
        if (GameControl.TapCount == 3 && EndGame == false)
        {
            audioManager.PlayAudio("TickCorrect");
            timer.StopClockCountDown();
            TextAnimation.SetTrigger("NextWord");

            if (timer.CountDown.fillAmount < 1)
            {
                ReloadTimer = true;
            }
            else
            {
                ReloadTimer = false;
            }
            if (ReloadTimer == false)
            {
                UpdateScore();
                GenerateWord();
                mixPos.ResetRandomPositionString();
                Invoke("NextRound", 0.5f);
                Invoke("DelayTime", 0.8f);

            }
        }
        if (timer.CountDown.fillAmount <= 0)
        {
            TextAnimation.runtimeAnimatorController = TutorialAnimator;
            EndGame = true;
            ReloadTimer = true;
            TextAnimation.SetTrigger("NextWord");

        }
        else if (timer.CountDown.fillAmount==1 && EndGame==true)
        {

           
            EndGame = false;
            audioManager.PlayAudio("Losing");
            ReloadTimer = false;
            timer.StopClockCountDown();
            mixPos.ResetRandomPositionString();
            Invoke("NextRound", 0.5f);
            Invoke("DelayTime", 0.8f);
           
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            if (Score > PlayerPrefs.GetInt("HighScore") && PlayerPrefs.GetInt("HighScore") != 0)
            {
                HighScoreCongrat.SetActive(true);
            }
            if (GameControl.TapCount == 3 && EndGame == false)
            {
                DecayMaxTimer();
                audioManager.PlayAudio("TickCorrect");
                timer.StopClockCountDown();
                TextAnimation.SetTrigger("NextWord");

                if (timer.CountDown.fillAmount < 1)
                {
                    ReloadTimer = true;
                }
                else
                {
                    ReloadTimer = false;
                }
                if (ReloadTimer == false)
                {
                    UpdateScore();
                    GenerateWord();
                    mixPos.ResetRandomPositionString();
                    Invoke("NextRound", 0.5f);
                    Invoke("DelayTime", 0.8f);

                }



            }
            if (timer.CountDown.fillAmount <= 0)
            {
                ReloadTimer = false;
                if (PlaySoundLosing == false)
                {
                    audioManager.PlayAudio("Losing");
                    PlaySoundLosing = true;
                }

                setUpCountDown.DisableCountDown();

                UpdateHighScore();
                EndGame = true;

                RestartPanel.SetActive(true);

            }
        }
    
    }
   
}
