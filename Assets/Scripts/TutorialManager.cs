using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    // Start is called before the first frame update
    // int 0 begin tutorial
    // int 1 tutorial has been done
  
    public int IsIntro;

    public GameObject reachScoreThree;
    public RandomString randomString;
    void Awake()
    {

        reachScoreThree.SetActive(false);
        if (PlayerPrefs.GetInt("Tutorial") == 0)
        {
            this.gameObject.GetComponent<Animator>().enabled = this.gameObject.GetComponent<Animator>().enabled;
                                      
            FindObjectOfType<GameManagement>().GenerateWord();
            randomString.GenerateRandomWord();
           
            FindObjectOfType<MixPosition>().GenerateRandomPositionString();
            FindObjectOfType<SetTimer>().StopClockCountDown();
           
            IsIntro = 1;
           
        }
        else
        {
            reachScoreThree.SetActive(false);
            IsIntro = 0;
            this.gameObject.GetComponent<Animator>().enabled = !this.gameObject.GetComponent<Animator>().enabled;
        }
      
    }
    private void Start()
    {
      
        StartCoroutine(SetIsIntro());
    }
    IEnumerator SetIsIntro()
    {
        yield return new WaitForSeconds(18.0f);
        IsIntro = 0;
        reachScoreThree.SetActive(true);
        FindObjectOfType<SetTimer>().CountinueClockCountDown();
      
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Tutorial") == 0)
        {
            if (FindObjectOfType<GameManagement>().Score >= 3)
            {
                reachScoreThree.SetActive(false);
                this.gameObject.GetComponent<Animator>().SetTrigger("DoneTutorial");
                FindObjectOfType<SetTimer>().StopClockCountDown();
                Invoke("ReloadGame", 2.0f);
            }
            else
            {
                FindObjectOfType<GameManagement>().ForTutorial();
            }
        }
        else
        {
            reachScoreThree.SetActive(false);
        }

    }
    void ReloadGame()
    {
        reachScoreThree.SetActive(false);
        PlayerPrefs.SetInt("Tutorial", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
