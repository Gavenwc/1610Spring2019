﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollideEvent : MonoEvents
{
    public UnityEvent Event;

    private void OncollisionEnter3D()
    {
        Event.Invoke();
    }

}
