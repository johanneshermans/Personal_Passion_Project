using UnityEngine;
using Proyecto26;
using Newtonsoft.Json;
using TMPro;
using System.Collections.Generic;
using System;

static class GetData
{
    static private string url = "https://dev4-personal-blog-backend.herokuapp.com/songs";

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
                var res = JsonConvert.DeserializeObject<List<SongMetaData>>(response.Text);
                Debug.Log(res);
                foreach (var song in res)
                {
                   Debug.Log(song.title);
                }
            }, error => { Debug.Log("oops!"); });
    }

}
