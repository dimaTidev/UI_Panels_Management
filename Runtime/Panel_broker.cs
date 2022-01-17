using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_broker : MonoBehaviour
{
    [SerializeField] PanelManagerUI panelManager = null;
    void Start()
    {
        if(panelManager)
            panelManager.SetMainPanel(gameObject);
    }
}
