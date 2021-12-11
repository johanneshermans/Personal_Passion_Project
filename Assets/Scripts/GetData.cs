using UnityEngine;
using Proyecto26;
using Newtonsoft.Json;
using TMPro;
using System.Collections.Generic;
using System;

public class GetData : MonoBehaviour
{
    private string url = "https://dev4-personal-blog-backend.herokuapp.com/songs";

    // Start is called before the first frame update

    public void DoRequest(string newTarget)
    {
        Debug.Log("Ik ben hier");
        Debug.Log(newTarget + "aangekomen");
        url = "https://dev4-personal-blog-backend.herokuapp.com/songs";
        getAllData();
    }

    private void getAllData()
    {
        RestClient.Get(url).Then(
            response =>
            {
                var res = JsonConvert.DeserializeObject<List<Song>>(response.Text);
                Debug.Log(res);
                foreach (var song in res)
                {
                   Debug.Log(song.title);
                }
            }, error => { Debug.Log("oops!"); });
    }




    class Song
    {
        public string title;
        public string artist;
        public string videoclip_link;
        public int bpm;
        public string info;
        public class Model
        {
            public string sort;
            public string text1;
            public string tex2;
            public string color1;
            public string color2;
            public string color3;
        }
        public class Screen_left
        {
            public string content_type;
            public string video_link;
        }
        public class Screen_right
        {
            public string content_type;
            public string video_link;
        }
        public string target;
    }

}
