using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class OnlinevideoLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string videoUrl = "yourvideourl";
    public Button BtnAddv;
    public string linka = "Users/khaled/StreamTG/Assets/videos/nature.mp4";

    // Update is called once per frame
    public void AddLink()
    {
        
        videoPlayer.url = linka;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
    }
}
