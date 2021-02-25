using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ResetModel : MonoBehaviour
{
    Vector3 originalpos, originalscale,posmo,scalemo, pospo, scalepo;
    Quaternion originalrotation,rotamo, rotapo;

    // Start is called before the first frame update
    void Start()
    {
        originalpos = transform.localPosition;
        originalscale = transform.localScale;
        originalrotation = transform.rotation;
    }

    public void returnmodel()
    {
        transform.localPosition = originalpos;
        transform.localScale = originalscale;
        transform.rotation = originalrotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
