﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine;

public class scrPlayLevel1 : MonoBehaviour {

     VideoPlayer video;

    private void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("Level1");
    }
}
