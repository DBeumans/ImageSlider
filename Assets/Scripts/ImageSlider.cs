using UnityEngine;
using System.Collections;

public class ImageSlider : MonoBehaviour
{
    public Texture2D[] slides;
    //public float changeTime = 1.0f;
    private int currentSlide = 0;
    //private float timeSinceLast = 1.0f;

    void Start()
    {
        transform.position = new Vector3(0.5f, 0.5f, 0.0f);
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        GetComponent<GUITexture>().texture = slides[currentSlide];
        GetComponent<GUITexture>().pixelInset = new Rect(-slides[currentSlide].width / 2.0f, -slides[currentSlide].height / 2.0f, slides[currentSlide].width, slides[currentSlide].height);
        currentSlide++;
    }

    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            currentSlide++;
            GetComponent<GUITexture>().texture = slides[currentSlide];
            GetComponent<GUITexture>().pixelInset = new Rect(-slides[currentSlide].width / 2.0f, -slides[currentSlide].height / 2.0f, slides[currentSlide].width, slides[currentSlide].height);
            
        }
        else if (Input.GetKeyDown("left"))
        {
            currentSlide--;
            GetComponent<GUITexture>().texture = slides[currentSlide];
            GetComponent<GUITexture>().pixelInset = new Rect(-slides[currentSlide].width / 2.0f, -slides[currentSlide].height / 2.0f, slides[currentSlide].width, slides[currentSlide].height);

        }


    }
}
