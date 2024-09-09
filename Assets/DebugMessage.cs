using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;
public class DebugMessage : MonoBehaviour
{
    public TextMeshPro textMesh, entitytextMesh,slider;

    public GameObject sliderObject,TV; // ���V�]�tPinchSlider�ե�GameObject

    private PinchSlider pinchSlider;

    public Light PointLight;

    public Camera camera;
    void Start()
    {
        if (sliderObject != null)
        {
            // ���oPinchSlider�ե�
            pinchSlider = sliderObject.GetComponent<PinchSlider>();

            if (pinchSlider != null)
            {
                // Ū��SliderValue
                All.Slider1 = pinchSlider.SliderValue;
                Debug.Log("��lSlider��: " + All.Slider1);
            }
            else
            {
                Debug.LogError("�䤣��PinchSlider�ե�I");
            }
        }
        else
        {
            Debug.LogError("�Ы��w�]�tPinchSlider��GameObject�I");
        }
        camera.clearFlags = CameraClearFlags.Skybox;
    }

    // Update is called once per frame
    void Update()
    {
        All.Slider1 = pinchSlider.SliderValue;
        PointLight.intensity = All.Slider1;
    }
    public void entitybutton_being()
    {
        entitytextMesh.text = "entitybutton_being";
    }
    public void entitybutton_end()
    {
        entitytextMesh.text = "entitybutton_end";
    }
    public void entitybutton_pressed()
    {
        entitytextMesh.text = "entitybutton_pressed";
        
    }
    public void button1_begin()
    {
        textMesh.text = "button1_begin";
    }
    public void button1_end()
    {
        if (TV.active)
        {
            TV.active = false;
            textMesh.text = "TV Off";
        }
        else if (!TV.active)
        {
            TV.active = true;
            textMesh.text = "TV On";
        }
    }
    public void button1_pressed()
    {
        textMesh.text = "button1_pressed";
    }
    public void button2_begin()
    {
        textMesh.text = "button2_begin";
    }
    public void button2_end()
    {
        textMesh.text = "button2_end";
    }
    public void button2_pressed()
    {
        textMesh.text = "button2_pressed";
    }
}
