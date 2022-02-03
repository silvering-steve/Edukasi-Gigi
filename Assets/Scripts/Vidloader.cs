using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
 
public class Vidloader : MonoBehaviour
{
     
    public VideoPlayer videoPlayer;
    public string videoUrl = "yourvideourl";
     
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.playOnAwake = false;
        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack (0, true);
        videoPlayer.Prepare ();
    }
 
    // Update is called once per frame
    void Update()
    {
         
    }

    public void PlayVid()
    {
        videoPlayer.Play();
    }

    public void PauseVid()
    {
        videoPlayer.Pause();
    }
}
