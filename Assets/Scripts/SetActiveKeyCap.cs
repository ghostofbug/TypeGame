using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveKeyCap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] KeyCaps;
    //public SetTimer countdown;
    public int KeyCapsPos;
    public SetTimer time;
    private string OldWord;
    private int WordIndex;
    void Start()
    {
        
    }
    public int FindPosition(char Alphabet)
    {
        int ButtonPos = -1;

        for (int i = 0; i < KeyCaps.Length; i++)
        {
            if (Alphabet.ToString()==KeyCaps[i].name)
            {
                ButtonPos = i;
                return ButtonPos;
            }
        }
        return ButtonPos;
    }
    // Update is called once per frame

}
