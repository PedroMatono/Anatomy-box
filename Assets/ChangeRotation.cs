using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class ChangeRotation : MonoBehaviour
{
    public GameObject model;
    public PinchSlider rotationSliderX, rotationSliderY, rotationSliderZ;
    private double newValue, convertedValue;

    // Start is called before the first frame update
    void Start()
    {
        if (model == null)
        {
            model = GetComponent<GameObject>();
        }
    }

    // Update is called once per frame
    public void rotationX()
    {
        newValue = rotationSliderX.SliderValue * 0.02;
        Debug.Log(newValue);

        if (newValue == 0 || newValue > 0.018)
        {
            model.transform.position = model.transform.position;
        }

        else if (newValue > 0.01)
        {
            model.transform.Rotate((float)newValue, 0, 0, Space.Self);
        }

        else
        {
            model.transform.Rotate(-(float)newValue, 0, 0, Space.Self);
        }

    }

    public void rotationY()
    {
        newValue = rotationSliderY.SliderValue * 0.02;
        Debug.Log(newValue);

        if (newValue == 0 || newValue > 0.018)
        {
            model.transform.position = model.transform.position;
        }

        else if (newValue > 0.01)
        {
            model.transform.Rotate(0, (float)newValue, 0, Space.Self);
        }

        else
        {
            model.transform.Rotate(0, -(float)newValue, 0, Space.Self);
        }

    }

    public void rotationZ()
    {
        newValue = rotationSliderZ.SliderValue * 0.02;
        Debug.Log(newValue);

        if (newValue == 0 || newValue > 0.018)
        {
            model.transform.position = model.transform.position;
        }

        else if (newValue > 0.01)
        {
            model.transform.Rotate(0, 0, (float)newValue, Space.Self);
        }

        else
        {
            model.transform.Rotate(0, 0, -(float)newValue, Space.Self);
        }

    }
}
