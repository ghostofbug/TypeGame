using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpCountDownAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CountDownAni;
    void Start()
    {
        CountDownAni = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void DisableCountDown()
    {
        CountDownAni.SetTrigger("IsActive");
    }
}
