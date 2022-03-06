using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentColor : MonoBehaviour
{
    public GameObject directionalLightObject;
    public GameObject morning;
    public GameObject afternoon;
    public GameObject evening;
    private Light directionalLight;
    public Color orangeC;

    void Start()
    {
        directionalLight = directionalLightObject.GetComponent<Light>();
    }

    public void UpdateColor()
    {
        if (directionalLight)
        {
            if (morning.activeSelf)
            {
                directionalLight.color = Color.yellow;
                directionalLight.renderMode = LightRenderMode.ForceVertex;
            }
            if (afternoon.activeSelf)
            {
                directionalLight.color = Color.white;
                directionalLight.renderMode = LightRenderMode.Auto;
            }
            if (evening.activeSelf)
            {
                directionalLight.color = orangeC;
                directionalLight.renderMode = LightRenderMode.ForceVertex;
            }
        }
    }
}
