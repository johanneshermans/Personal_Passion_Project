using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class SideScreens : MonoBehaviour
{
    public string side = "left";
    public string content = "video";
    public string videoUrl = "https://res.cloudinary.com/dd04ardpv/video/upload/v1638311473/Avicii_-_Waiting_For_Love_ldfali.mp4";
    public TextMeshPro textMeshProRight;
    public TextMeshPro textMeshProLeft;
    public VideoPlayer videoPlayerLeft;
    public VideoPlayer videoPlayerRight;


    // Start is called before the first frame update
    void Start()
    {
        HandleScreen();
    }

    void HandleScreen()
    {
        if (side == "left" && content == "video")
        {
            //ShowVideo();
            
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
        videoPlayerLeft.url = videoUrl;
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayerLeft.EnableAudioTrack(0, true);
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
