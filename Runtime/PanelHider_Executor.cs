using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHider_Executor : MonoBehaviour
{
    [SerializeField] HideEvents[] hideEvents = null;

    [System.Serializable]
    public class HideEvents
    {
#if UNITY_EDITOR
#pragma warning disable 0414
        [SerializeField] string e_label = "Editor label";
#pragma warning restore 0414
#endif

        [SerializeField] bool isActiveOnEnable = true;
        [SerializeField] PanelHide_Event eventData;

        public void Set_Enable(bool isEnable)
        {
            if (eventData)
                eventData.Set_Enable(isActiveOnEnable ? isEnable : !isEnable);
        }
    }


    private void OnEnable()
    {
        if (hideEvents != null)
            for (int i = 0; i < hideEvents.Length; i++)
                hideEvents[i].Set_Enable(true);
    }

    private void OnDisable()
    {
        if (hideEvents != null)
            for (int i = 0; i < hideEvents.Length; i++)
                hideEvents[i].Set_Enable(false);
    }
}
