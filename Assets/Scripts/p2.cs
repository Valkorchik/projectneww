﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class p2 : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void Backward()
    {
        videoPlayer.time = videoPlayer.time + 5;
    }
}
