using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]
public class Sound
{
    public string SoundName;
    public bool IsLoop;
    public AudioClip audioClip;
    public float Volume;
    public AudioSource soundPlay;
}
public class AudioManager : MonoBehaviour
{
    public Sound[] ListSound;

    private void Start()
    {
    
        for (int i=0;i<ListSound.Length;i++)
        {
        
            ListSound[i].soundPlay = gameObject.AddComponent<AudioSource>();
            ListSound[i].SoundName = ListSound[i].audioClip.name;
            ListSound[i].soundPlay.volume = ListSound[i].Volume;
        }
    }
    public  void PlayAudio(string AudioName)
    {
        bool CanFind = false;
        for (int i=0;i<ListSound.Length;i++)
        {
            if (AudioName==ListSound[i].SoundName && PlayerPrefs.GetInt("Volume")==0)
            {
                ListSound[i].soundPlay.clip = ListSound[i].audioClip;
                ListSound[i].soundPlay.loop = ListSound[i].IsLoop;
                ListSound[i].soundPlay.Play();
                CanFind = true;
                break;
            }
        }
        if (CanFind==false)
        {
            Debug.Log("Sound not found");
        }
    }
    public void MuteSound()
    {
        for (int i=0;i<ListSound.Length;i++)
        {
            ListSound[i].soundPlay.volume = 0;
        }
    }
    public void NonMuteSound()
    {
        for (int i=0;i<ListSound.Length;i++)
        {
            ListSound[i].soundPlay.volume = ListSound[i].Volume;
        }
    }

}
