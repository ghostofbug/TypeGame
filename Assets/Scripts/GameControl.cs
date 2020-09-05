using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameControl : MonoBehaviour
{
    public SetTimer time;
    public Button Bt;
    public GameManagement gameManage;
    public static int TapCount=0;
    public Animator Error;


    public AudioManager audioManager;
    public void DisplayRestartPanel()
    {

    }
    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        Bt = GetComponent<Button>();
        Bt.onClick.AddListener(ShowName);
       
    }
   
   
    void ShowName()
    {
        audioManager.PlayAudio("KeyStroke");
        string temp = Bt.name;
        switch (FindObjectOfType<TutorialManager>().IsIntro)
        {
            case 0:
                

             


                if (gameManage.CheckAlphabet(temp) == true)
                {
                    TapCount++;

                  
                }
                else
                {
                    Error.SetTrigger("Error");
                    audioManager.PlayAudio("Error");
                    time.IsWrong = true;
                    time.PunishTime = 0.00001f;

                }
                break;
            case 1:
                break;
            default:
            
                if (gameManage.CheckAlphabet(temp) == true)
                {
                    TapCount++;

                }
                else
                {
                    Error.SetTrigger("Error");
                    audioManager.PlayAudio("Error");
                    time.IsWrong = true;
                    time.PunishTime = 0.01f;

                }
                break;


        }

     
   
    }
    
}
