using System;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private GameObject _timelineCamera;
    [SerializeField] private GameObject HUD;
    [SerializeField] private GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Play();
    }


    [ContextMenu("Play")]
    public void Play()
    {
        _timelineCamera.SetActive(true);
        HUD.SetActive(false);
        Player.SetActive(false);
        _director.Play();
        _director.stopped += HandleEnd;
        GetComponent<BoxCollider>().enabled = false;
   
    }

    private void HandleEnd(PlayableDirector director)
    {
        Debug.Log("HandleEnd");
        _timelineCamera.SetActive(false);
        HUD.SetActive(true);
        Player.SetActive(true);
    }
}
