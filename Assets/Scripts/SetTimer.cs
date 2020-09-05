using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour
{
   
    public bool IsWrong;
    public float PunishTime;
    public float timeMax;
    private float Speed;
    public Image CountDown;
    public float Increment;
    public GameManagement gameManagement;    // Start is called before the first frame update
    void Start()
    {
        CountDown.fillAmount = 1;
        PunishTime = 0;
        IsWrong = false;
        
    }

    // Update is called once per frame
    public void StopClockCountDown()
    {
        Speed = 0.0f;
    }
    public void CountinueClockCountDown()
    {
        Speed = 1.0f;
       

    }
    void Update()
    {
        if (CountDown.fillAmount > 0 && gameManagement.ReloadTimer==false)
        {
        
         
            CountDown.fillAmount = CountDown.fillAmount - Speed*(1.0f / timeMax * Time.deltaTime);
            if (IsWrong==true)
            {
                CountDown.fillAmount = CountDown.fillAmount - PunishTime;
                IsWrong = false;
            }
        }
        if (gameManagement.ReloadTimer==true && CountDown.fillAmount>=0)
        {
            CountDown.fillAmount = CountDown.fillAmount + Time.deltaTime + Increment;
           
        }
      
    
    }
}
