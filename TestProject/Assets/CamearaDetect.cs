using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;

public class CamearaDetect : MonoBehaviour
{
    // Start is called before the first frame update
    WebCamTexture _webCamtexture;
    CascadeClassifier cascade;
    OpenCvSharp.Rect MyFace;
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        _webCamtexture = new WebCamTexture(devices[0].name);
        _webCamtexture.Play();
        cascade = new CascadeClassifier(Application.dataPath + "/hand.xml");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTexture = _webCamtexture;
        Mat frame = OpenCvSharp.Unity.TextureToMat(_webCamtexture);

        findNewhand(frame);
        display(frame);
    }
    void findNewhand(Mat frame){
        var hand = cascade.DetectMultiScale(frame, 1.1f, 2, HaarDetectionType.ScaleImage);
        if(hand.Length >= 1){
            Debug.Log(hand[0].Location);
            MyFace = hand[0];
        }
    }
    void display(Mat frame){
        if(MyFace != null){
            frame.Rectangle(MyFace, new Scalar(250, 0 ,0),2);
        }
        Texture newtexture = OpenCvSharp.Unity.MatToTexture(frame);
        GetComponent<Renderer>().material.mainTexture = newtexture;
    }
}
