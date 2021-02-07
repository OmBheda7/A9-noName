using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRInput : MonoBehaviour
{
    private InputDevice targetDev;
    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevices(devices);

        foreach (var i in devices)
        {
            Debug.Log(i.name + i.characteristics);
        }

        InputDeviceCharacteristics rightControl = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControl, devices);

        if (devices.Count > 0)
        {
            targetDev = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        targetDev.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);




    }
}
