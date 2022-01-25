using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class Panel_broker : MonoBehaviour
{
    [SerializeField] PanelManagerUI panelManager = null;
    void Awake()
    {
        if(panelManager)
            panelManager.SetMainPanel(gameObject);
    }
}
