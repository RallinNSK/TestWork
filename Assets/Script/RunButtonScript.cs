using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Characters.ThirdPerson;

public class RunButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    private ThirdPersonCharacter player;

    private void Start()
    {
        player = FindObjectOfType<ThirdPersonCharacter>();
    }

    public void OnPointerDown(PointerEventData data)
    {
        player.m_Run = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        player.m_Run = false;
    }
}
