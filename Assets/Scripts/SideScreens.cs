using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SideScreens : MonoBehaviour
{
    public string side = "left";
    public string content = "video";
    public string videoUrl = "https://res.cloudinary.com/dd04ardpv/video/upload/v1638311473/Avicii_-_Waiting_For_Love_ldfali.mp4";
    public TextMeshPro textMeshProRight;
    public TextMeshPro textMeshProLeft;

    // Start is called before the first frame update
    void Start()
    {
        HandleScreen();
    }

    void HandleScreen()
    {
        if (side == "left" && content == "video")
        {
            ShowVideo("LeftScreen");
            
        }
        else if (side == "left" && content == "text")
        {
            ShowText("left");
        }
        else if (side == "right" && content == "video")
        {
            ShowVideo("RightScreen");
        }
        else if (side == "right" && content == "text")
        {
            ShowText("right");
        }


    }

    void ShowVideo(string side)
    {
        GameObject plane = GameObject.Find(side);
        var videoPlayer = plane.AddComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.url = videoUrl;
        videoPlayer.EnableAudioTrack(0, false);
        videoPlayer.Prepare();
        videoPlayer.Play();
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
