
using MixedReality.Toolkit.UX;
using UnityEngine;



public class SliderSolarSystemScale : MonoBehaviour
{
    public GameObject solarSystemGO;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sliderValue = GetComponent<Slider>().Value;

        solarSystemGO.transform.localScale = new Vector3(sliderValue, sliderValue, sliderValue);
        
    }
}
