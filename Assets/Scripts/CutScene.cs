using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutScene : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject CutOn;
    public GameObject CutDel;
    public GameObject Hiro;

    void OnTimelineStopped()
    {
        Debug.Log("Des");
        Hiro.SetActive(true);
        Destroy(CutDel);
    }
    void OnTriggerEnter(Collider collision)
    {
        Hiro.SetActive(false);
        CutOn.SetActive(true);
        timeline.Play();        
        Invoke("OnTimelineStopped", 40f);
    }
   
}
