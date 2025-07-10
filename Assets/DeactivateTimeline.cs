using System;
using UnityEngine;
using UnityEngine.Playables;

public class DeactivateTimeline : MonoBehaviour
{
    [SerializeField] private GameObject _cineCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<PlayableDirector>().stopped += Deactivate;
    }

    private void Deactivate(PlayableDirector director)
    {
       _cineCamera.SetActive(false);
    }
}
