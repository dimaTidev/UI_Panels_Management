using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PanelManager", menuName = "ScriptableObjects/PanelManager")]
public class PanelManagerUI : ScriptableObject
{
    GameObject mainPanel;
    Stack<GameObject> history = new Stack<GameObject>();
    [SerializeField] AudioClip aClip_next = null;
    [SerializeField] AudioClip aClip_redo = null;
    AudioSource _aSource;

    AudioSource ASource
    {
        get
        {
            if (!_aSource)
            {
                GameObject go = new GameObject("Sound_MenuPanels");
                _aSource = go.AddComponent<AudioSource>();
                _aSource.playOnAwake = false;
            }
            return _aSource;
        }
    }

    public void GoTo(GameObject t_go)
    {
        if (t_go == null)
            return;

        if (history.Count == 0 || history.Peek() != t_go)
        {
            if (history.Count > 0 && history.Peek() != null)
                history.Peek().SetActive(false);
            history.Push(t_go);
            t_go.SetActive(true);
            PlaySound(aClip_next);
        }
        else
            Redo();
    }
    public void Redo()
    {
        if (history.Count > 1 && history.Peek() != null)
        {
            history.Pop().SetActive(false);
            PlaySound(aClip_redo);
        }


        if (history.Count > 0 && history.Peek() != null)
            history.Peek().SetActive(true);
    }

    public void FollowMain()
    {
        if (!mainPanel)
            return;
        if (history.Count > 0)
            history.Peek().SetActive(false);

        history.Clear();
        history.Push(mainPanel);
        mainPanel.SetActive(true);
    }

    
    public void SetMainPanel(GameObject panel)
    {
        mainPanel = panel;
        FollowMain();
    }

    void PlaySound(AudioClip aClip)
    {
        if (aClip == null)
            return;
        ASource.clip = aClip;
        ASource.Play();
    }
}
