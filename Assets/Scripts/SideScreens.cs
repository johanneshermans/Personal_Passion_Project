using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class SideScreens : MonoBehaviour
{
    //public string side = "left";
    //public string content = "video";
    public TextMeshPro textMeshProRight;
    public TextMeshPro textMeshProLeft;
    public VideoPlayer videoPlayerLeft;
    public VideoPlayer videoPlayerRight;

    private void Start()
    {
        GetData.sideScreens = this;
    }

    public void LeftScreen(string content, string link, string text)
    {
        if (content == "video")
        {
            ShowVideo(videoPlayerLeft, link);
        } else if (content == "text")
        {
            ShowText(textMeshProLeft, text);
        }
    }

    public void RightScreen(string content, string link, string text)
    {
        if (content == "video")
        {
            ShowVideo(videoPlayerRight, link);
        }
        else if (content == "text")
        {
            ShowText(textMeshProRight, text);
        }
    }


    private void ShowVideo(VideoPlayer side, string link)
    {
        side.url = link;
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        side.EnableAudioTrack(0, true);
        //videoPlayerLeft.SetDirectAudioMute(ushort, mute);
        side.Prepare();
        side.Play();
    }

    private void ShowText(TextMeshPro side, string text)
    {
        Debug.Log(text);
        side.SetText("Avicii - Waiting for love");
    }

}
