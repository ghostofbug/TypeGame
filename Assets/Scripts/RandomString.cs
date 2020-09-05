using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class RandomString : MonoBehaviour
{
    public Text[] DisplayText;
    
    // Start is called before the first frame update
    public int MaxLength;
    public static string RandomWord;
    public static string OrderWord;
    public Dictionary3Word Dictionary;
    public int[] ListPositionRandom;
    void Start()
    {
        RandomWord = "123"; 
        
    }
    public void SetListPosition(int a,int b,int c)
    {
        ListPositionRandom[0] = a;
        ListPositionRandom[1] = b;
        ListPositionRandom[2] = c;
    }
    public void RandomOrderWord()
    {
        int randomType = Random.Range(0, 6);
        string tempPos1 = RandomWord[0].ToString();
        string tempPos2 = RandomWord[1].ToString();
        string tempPos3 = RandomWord[2].ToString();
        switch(randomType)
        {
            //123
            case 0:
                OrderWord = tempPos1 + tempPos2 + tempPos3;
                SetListPosition(1, 2, 3);
                break;

            //321
            case 1:
                OrderWord = tempPos3 + tempPos2 + tempPos1;
                SetListPosition(3, 2, 1);
                break;

            //231
            case 2:
                OrderWord = tempPos2 + tempPos3 + tempPos1;
                SetListPosition(2, 3, 1);
                break;

            //213
            case 3:
                OrderWord = tempPos2 + tempPos1 + tempPos3;
                SetListPosition(2, 1, 3);
                break;

            //132
            case 4:
                OrderWord = tempPos1 + tempPos3 + tempPos2;
                SetListPosition(1, 3, 2);
                break;
            //312
            case 5:
                OrderWord = tempPos3 + tempPos1 + tempPos2;
                SetListPosition(3, 1, 2);
                break;


            default:
                break;
        }
    }
    // Update is called once per frame\
    public void UpdateColorText()
    {
       
        DisplayText[ListPositionRandom[GameControl.TapCount]-1].color = Color.white;
    }
    public void GenerateRandomWord()
    {


        
        RandomWord = Dictionary.GetRandomWord();
        if (RandomStringForMenu.SyncWord != null)
        {

            RandomWord = RandomStringForMenu.SyncWord;
            RandomStringForMenu.SyncWord = null;
            Debug.Log("Co vo day");
        }
        if (RandomWord == null)
        {
            Debug.Log("CHuoi null");
        }
        else
        {
            Debug.Log(RandomWord);
        }
        RandomOrderWord();
        DisplayWord();

    }
    public void DisplayWord()
    {
        for (int i = 0; i < DisplayText.Length; i++)
        {
            DisplayText[i].color = new Color(0.196f, 0.196f, 0.196f);
            DisplayText[i].text = RandomWord[i].ToString();
        }
    }
   
}
