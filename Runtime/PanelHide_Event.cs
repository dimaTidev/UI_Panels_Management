using UnityEngine;
using System;

[CreateAssetMenu(fileName = "name", menuName = "ScriptableObjects/PanelManagement/Panel hide event")]
public class PanelHide_Event : ScriptableObject
{
#if UNITY_EDITOR
#pragma warning disable 0414
    [SerializeField, TextArea] string e_label = "Editor description";
#pragma warning restore 0414
#endif
    public event Action<bool> OnEnable;
    public void Set_Enable(bool isEnable) => OnEnable?.Invoke(isEnable);
}
