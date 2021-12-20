using UnityEngine;
using Proyecto26;
using Newtonsoft.Json;
using TMPro;
using System.Collections.Generic;
using System;

static class GetData
{
    static private string url = "https://dev4-personal-blog-backend.herokuapp.com/songs";
    static public SideScreens sideScreens;
    static public LoadOnlineVideo loadOnlineVideo;
    static public ManagePrefabs managePrefabs;
    static public SimpleCloudRecoEventHandler cloudReco;

    // Start is called before the first frame update
    static public void DoRequest(string newTarget)
    {
        url = "https://dev4-personal-blog-backend.herokuapp.com/songs?target=" + newTarget;
        getAllData();
    }

    static private void getAllData()
    {
        RestClient.Get(url).Then(
            response =>
            {
                var res = JsonConvert.DeserializeObject<List<Root>>(response.Text);
                Debug.Log(res);
                foreach (var song in res)
                {
                    Debug.Log(song.artist);
                    loadOnlineVideo.Play(song.videoclip_link);
                    sideScreens.LeftScreen(song.screen_left.content_type, song.screen_left.video_link, song.info);
                    sideScreens.RightScreen(song.screen_right.content_type, song.screen_left.video_link, song.info);
                    managePrefabs.ChangeWorlds(song.model.sort, song.model, song.bpm);

                }
            }, error => { Debug.Log("oops!"); });
    }


    static public void Reset()
    {
        cloudReco.Reset();
        sideScreens.Stop();
        loadOnlineVideo.Stop();
        managePrefabs.Reset();
    }
}
