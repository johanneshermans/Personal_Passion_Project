using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class SideScreens : MonoBehaviour
{
    public string side = "left";
    public string content = "video";
    string videoUrl = "https://res.cloudinary.com/dd04ardpv/video/upload/v1639398447/y2meta.com-Avicii_-_Waiting_For_Love_Lyrics_-_1080p_dwdjf7.mp4";
    public TextMeshPro textMeshProRight;
    public TextMeshPro textMeshProLeft;
    public VideoPlayer videoPlayerLeft;
    public VideoPlayer videoPlayerRight;

    private void Start()
    {
        GetData.sideScreens = this;
    }

    public void GetParameters(string link)
    {
        Debug.Log("test");
        Debug.Log(link + "juiste plaats");
        HandleScreen();

        
    }

    void HandleScreen()
    {
        if (side == "left" && content == "video")
        {
            ShowVideo();
            
        }
        else if (side == "left" && content == "text")
        {
            ShowText("left");
        }
        else if (side == "right" && content == "video")
        {
            ShowVideo();
        }
        else if (side == "right" && content == "text")
        {
            ShowText("right");
        }


    }

    public void ShowVideo()
    {
        Debug.Log("komt hier");
        Debug.Log(videoUrl);
        videoPlayerLeft.url = videoUrl;
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayerLeft.EnableAudioTrack(0, true);
        //videoPlayerLeft.SetDirectAudioMute(ushort, mute);
        videoPlayerLeft.Prepare();
        videoPlayerLeft.Play();
    }

    void ShowText(string side)
    {
        if (side == "right")
        {
            textMeshProRight.SetText("Avicii - Waiting for love");
        }
        if (side == "left")
        {
            textMeshProLeft.SetText("Avicii - Waiting for love");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
