using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PanelHider_Broker : MonoBehaviour
{
    [SerializeField] PanelHide_Event eventData;

    private void Awake()
    {
        if (eventData)
            eventData.OnEnable += OnEnableEvent;
    }

    private void OnDestroy()
    {
        if (eventData)
            eventData.OnEnable -= OnEnableEvent;
    }

    void OnEnableEvent(bool isEnable) => gameObject.SetActive(isEnable);
}