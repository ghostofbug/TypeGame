using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPlaceMent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Keycap;
    //public Camera camera;
    void Start()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/10.0f, Screen.height, 0));
        Debug.Log(position.x);
        for (int i=0;i<Keycap.Length;i++)
        {
            Keycap[i].transform.position = new Vector2(position.x * i, position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
