using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadOnlineVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string videoUrl = "https://studenthowest-my.sharepoint.com/personal/johannes_hermans_student_howest_be/_layouts/15/onedrive.aspx?id=%2Fpersonal%2Fjohannes%5Fhermans%5Fstudent%5Fhowest%5Fbe%2FDocuments%2FAvicii%20%2D%20Waiting%20For%20Love%2Emp4&parent=%2Fpersonal%2Fjohannes%5Fhermans%5Fstudent%5Fhowest%5Fbe%2FDocuments";

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("run");
        videoPlayer.url = videoUrl;
        //videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        //videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

}