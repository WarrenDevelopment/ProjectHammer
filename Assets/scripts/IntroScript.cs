using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour {

    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component

    void Start() {

        Debug.Log("lol");
        bool down = Input.GetKeyDown(KeyCode.Space);

        if ( down ) {
            Debug.Log("lol1.2");
            SceneManager.LoadScene(1);
        }

        VideoPlayer.loopPointReached += LoadScene;


    }

    void LoadScene(VideoPlayer vp) {
        Debug.Log("lol2");
        SceneManager.LoadScene( 1 );
    }

 }
