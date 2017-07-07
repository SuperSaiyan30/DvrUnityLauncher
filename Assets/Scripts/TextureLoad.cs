
using UnityEngine;
using System;
using UnityEngine.UI;
public class TextureLoad : MonoBehaviour
{
    // Use this for initialization
    Texture2D texture2D = null;
    //GameObject plane = null;
   
    Image img = null;
    Sprite sprite = null;
    Int32 texPtr = 0;
    AndroidJavaObject mImageLoader;
    private const int TexWidth = 1920;
    private const int TexHeight = 1200;
    public Renderer render = null;
    Texture2D nativeTexture;
    void Start()
    {
        Debug.Log("TextureLoad start()");
        //plane = GameObject.Find("Plane");
        //render = plane.GetComponent<Renderer>();
        //define ad Texture2D object to receive texture from android side
        texture2D = new Texture2D(TexWidth, TexHeight, TextureFormat.ARGB32, false);
        //obtain the android java object LoadTexture2D

        mImageLoader = new AndroidJavaObject("com.dlo.dvrlauncher.MainActivity");
        //call function loadImageRecturenTexturePtr to get the TexturePtr
        texPtr = mImageLoader.Call<Int32>("GetTexturePtr", TexWidth, TexHeight);
        //print the texPtr
        Debug.Log("aatexture pointer= " + texPtr.ToString());
        // use the texPtr from android side to create a Texture2D object
        nativeTexture = Texture2D.CreateExternalTexture(TexWidth, TexHeight, TextureFormat.ARGB32, false, false, (IntPtr)texPtr);
 
        //update texture2D with nativeTexture
        texture2D.UpdateExternalTexture(nativeTexture.GetNativeTexturePtr());
        //sprite = Sprite.Create(texture2D, new Rect(0, 0, 1920, 1200), Vector2.zero);
        //sprite = Sprite.Create(texture2D, new Rect(0, 0, 1920, 1200), new Vector2(0.5f, 0.5f));
        render.material.mainTexture = texture2D;
    }
    // Update is called once per frame
    void Update()
    {
        //bind texture to gameobject in unity
        render.sharedMaterial.mainTexture = texture2D;

        //img.material.mainTexture = texture2D;
        // img.sprite = sprite;
    }
}
