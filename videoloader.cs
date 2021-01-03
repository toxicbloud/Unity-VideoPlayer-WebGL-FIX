using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.Video;

public class videoLoader : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    You should put this script on the same component that have the VideoPlayer component
    */
    private VideoPlayer videoPlayer;
    [SerializeField]
    private string nomVideo; //name of your video file with his extension like hello.mp4
    void Start()
    {
        videoPlayer = gameObject.GetComponent<VideoPlayer>(); 
        videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,nomVideo);
        videoPlayer.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
