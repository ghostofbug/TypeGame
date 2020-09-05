using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlIndicator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public float speed;
    public RandomString randomString;
    public Vector2 velocity;
    public float time;
    void Start()
    {
        randomString = FindObjectOfType<RandomString>();
        velocity = Vector2.zero;
    }
    private void MoveIndicator(int Pos)
    {
        if (Pos==1)
        {
            //this.transform.position = Vector2.MoveTowards(this.transform.position, pos1.position, speed * Time.deltaTime);
            this.transform.position = Vector2.SmoothDamp(this.transform.position, pos1.position, ref velocity, time);
        }
        else if (Pos==2)
        {
           // this.transform.position = Vector2.MoveTowards(this.transform.position, pos2.position, speed * Time.deltaTime);
            this.transform.position = Vector2.SmoothDamp(this.transform.position, pos2.position, ref velocity, time);
        }
        else if (Pos==3)
        {
          //  this.transform.position = Vector2.MoveTowards(this.transform.position, pos3.position, speed * Time.deltaTime);
            this.transform.position = Vector2.SmoothDamp(this.transform.position, pos3.position, ref velocity, time);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (GameControl.TapCount==1)
        {
            MoveIndicator(randomString.ListPositionRandom[1]);
        }
        if (GameControl.TapCount==2)
        {
            MoveIndicator(randomString.ListPositionRandom[2]);
        }
        if (GameControl.TapCount==0)
        {
            MoveIndicator(randomString.ListPositionRandom[0]);
        }
    }
}
