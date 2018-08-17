using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyWithColorAttribute : PropertyAttribute {

    public float r, g, b;

    public ReadOnlyWithColorAttribute()
    {
        r = 0.0f;
        g = 1.0f;
        b = 0.0f;
    }

    public ReadOnlyWithColorAttribute(float _r, float _g, float _b)
    {
        r = _r;
        g = _g;
        b = _b;
    }

}
