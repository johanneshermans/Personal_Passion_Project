using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadOnlineVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    string videoUrl = "https://res.cloudinary.com/dd04ardpv/video/upload/v1638311473/Avicii_-_Waiting_For_Love_ldfali.mp4";

    public void Play()
    {

        videoPlayer.url = videoUrl;
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

}