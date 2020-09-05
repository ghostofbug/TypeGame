using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MixPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public SetActiveKeyCap pos1;
    public SetActiveKeyCap pos2;
    public SetActiveKeyCap pos3;


    public int RandomType;

    public int Position1Index;
    public int Position2Index;
    public int Position3Index;
    public SetTimer time;
    void Start()
    {
       
    }

    private void RandomPosition()
    {
        int tempPos1 = Position1Index;
        int tempPos2 = Position2Index;
        int tempPos3 = Position3Index;
        switch (RandomType)
        {
            case 0:
                Position1Index = tempPos1;
                Position2Index = tempPos2;
                Position3Index = tempPos3;
                break;
            case 1:
                Position1Index = tempPos3;
                Position2Index = tempPos2;
                Position3Index = tempPos1;
                break;
            case 2:
                Position1Index = tempPos1;
                Position2Index = tempPos3;
                Position3Index = tempPos2;
                break;
            case 3:
                Position1Index = tempPos2;
                Position2Index = tempPos3;
                Position3Index = tempPos1;
                break;
            case 4:
                Position1Index = tempPos3;
                Position2Index = tempPos1;
                Position3Index = tempPos2;
                break;
            case 5:
                Position1Index = tempPos2;
                Position2Index = tempPos1;
                Position3Index = tempPos3;
                break;

            default:
                break;
        }
    }

    public void GenerateRandomPositionString()
    {
      
        pos1.KeyCaps[Position1Index].SetActive(false);
        pos2.KeyCaps[Position2Index].SetActive(false);
        pos3.KeyCaps[Position3Index].SetActive(false);
      
        Position1Index = pos1.FindPosition(RandomString.RandomWord[pos1.KeyCapsPos]);
        Position2Index = pos2.FindPosition(RandomString.RandomWord[pos2.KeyCapsPos]);
        Position3Index = pos3.FindPosition(RandomString.RandomWord[pos3.KeyCapsPos]);
      
        RandomType = Random.Range(0, 6);
        RandomPosition();
        pos1.KeyCaps[Position1Index].SetActive(true);
        pos2.KeyCaps[Position2Index].SetActive(true);
        pos3.KeyCaps[Position3Index].SetActive(true);
        pos1.KeyCaps[Position1Index].GetComponent<Button>().interactable = true;
        pos2.KeyCaps[Position2Index].GetComponent<Button>().interactable = true;
        pos3.KeyCaps[Position3Index].GetComponent<Button>().interactable = true;

    }
    private Animator ButtonAnimator1;
    private Animator ButtonAnimator2;
    private Animator ButtonAnimator3;
    public void ResetRandomPositionString()
    {
        RandomType = Random.Range(0, 6);

        pos1.KeyCaps[Position1Index].GetComponent<Animator>().ResetTrigger("Pressed");
        pos2.KeyCaps[Position2Index].GetComponent<Animator>().ResetTrigger("Pressed");
        pos3.KeyCaps[Position3Index].GetComponent<Animator>().ResetTrigger("Pressed");
        pos1.KeyCaps[Position1Index].GetComponent<Animator>().ResetTrigger("Highlighted");
        pos2.KeyCaps[Position2Index].GetComponent<Animator>().ResetTrigger("Highlighted");
        pos3.KeyCaps[Position3Index].GetComponent<Animator>().ResetTrigger("Highlighted");
        pos1.KeyCaps[Position1Index].GetComponent<Animator>().ResetTrigger("Normal");
        pos2.KeyCaps[Position2Index].GetComponent<Animator>().ResetTrigger("Normal");
        pos3.KeyCaps[Position3Index].GetComponent<Animator>().ResetTrigger("Normal");


        pos1.KeyCaps[Position1Index].GetComponent<Button>().interactable = false;
        pos2.KeyCaps[Position2Index].GetComponent<Button>().interactable = false;
        pos3.KeyCaps[Position3Index].GetComponent<Button>().interactable = false;
        pos1.KeyCaps[Position1Index].GetComponent<Animator>().ResetTrigger("Disabled");
        pos2.KeyCaps[Position2Index].GetComponent<Animator>().ResetTrigger("Disabled");
        pos3.KeyCaps[Position3Index].GetComponent<Animator>().ResetTrigger("Disabled");


    }
    
}
    
   
        


