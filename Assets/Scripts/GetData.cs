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
                }
            }, error => { Debug.Log("oops!"); });
    }

}
