﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoTransition : MonoBehaviour
{
    public VideoPlayer videoIntro;

    private void Awake()
    {
        videoIntro = GetComponent<VideoPlayer>();
        videoIntro.Play();
        videoIntro.loopPointReached += VideoIntro_ended;
    }

    private void VideoIntro_ended(VideoPlayer source)
    {
        MakeSceneTransition();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.KeypadEnter))
            MakeSceneTransition();
    }

    private void MakeSceneTransition()
    {
        if (SceneManager.GetActiveScene().name == "MainIntro")
            SceneManager.LoadScene("MainMenu");

        else if (SceneManager.GetActiveScene().name == "MainMenu")
            SceneManager.LoadScene("MainMenu");

        else if (SceneManager.GetActiveScene().name == "GameIntro")
            //SceneManager.LoadScene("MainGameScene");
            Debug.Log("Escena principal");
    }
}
