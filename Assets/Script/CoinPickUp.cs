using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameController gameController = FindObjectOfType<GameController>();

        gameController.coin++;
        gameController.textCoin.text = gameController.coin.ToString();
        Destroy(gameObject);
    }

}
