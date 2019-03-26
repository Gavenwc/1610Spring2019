using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, TriggerEnterEvent, UpdateEvent;
    
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }

    private void OnTriggerEnter()
    {
        TriggerEnterEvent.Invoke();
    }

    void Update()
    {
        UpdateEvent.Invoke();
    }
}
