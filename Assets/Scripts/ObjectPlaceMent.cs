using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlaceMent : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform ScoreUI;
    public Transform Pos16_9;
    public Transform Pos19_9;
    public Transform Pos21_9;
    public Transform Pos18_9;
   // public Transform Pos3_2;
  //  public Transform Pos4_3;
  //  public Transform Pos5_4;
 
    private void Awake()
    {
        if (Camera.main.aspect>=2.3)
        {
          
            ScoreUI.transform.position = Pos21_9.position;
        }
        else if (Camera.main.aspect >=2.1)
        {
            ScoreUI.transform.position = Pos19_9.position;
        }
        else if (Camera.main.aspect>=2)
        {
            ScoreUI.transform.position = Pos18_9.position;
        }
        else if (Camera.main.aspect>=1.7)
        {
            ScoreUI.transform.position = Pos16_9.position;
        }
     //   else if (Camera.main.aspect>=1.5)
        {
         //   ScoreUI.transform.position = Pos3_2.position;
        }
      //  else if (Camera.main.aspect>=1.3)
      //  {
       //     ScoreUI.transform.position = Pos4_3.position;
      //  }
      //  else if (Camera.main.aspect>=1.25)
      //  {
      //      ScoreUI.transform.position = Pos5_4.position;
       // }

    }
    void Start()
    {
      
     
    
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
