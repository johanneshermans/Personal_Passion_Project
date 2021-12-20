using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadOnlineVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    string videoUrl = "";

    private void Start()
    {
        GetData.loadOnlineVideo = this;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
    }

    public void Play(string link)
    {
        videoUrl = link;
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    public void Stop()
    {
        Debug.Log("Reset Video");
        videoPlayer.Stop();
        videoUrl = "";
    }

}