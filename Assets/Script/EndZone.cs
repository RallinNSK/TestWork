using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameController gameController = FindObjectOfType<GameController>();

        gameController.EndScoreView();
    }
}
