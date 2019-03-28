using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [Header("Panel")]
    public GameObject startPanel;
    public GameObject endScorePanel;
    public GameObject gameOverPanel;

    [Header("Coin Controller")]
    public GameObject[] coinSpawnPoint;
    public GameObject coinPrefab;

    public int coinSpawnCol;
    public int coin;
    public Text textCoin;
    public Text finalTextCoin;

    [Header("Timer check")]
    public bool useTimer;

    public void StartGame()
    {
        startPanel.SetActive(false);
        useTimer = !useTimer;
        SpawnCoin();
    }

    public void EndScoreView()
    {
        endScorePanel.SetActive(true);
        finalTextCoin.text = textCoin.text;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    //Перезагрузка сцены для рестарта
    public void Restart()
    {
        SceneManager.LoadScene(0); 
    }

    public void SpawnCoin()
    {
        FisherSort();
        coinSpawnCol = (int)Random.Range(13, coinSpawnPoint.Length);
        for (int i = 0; i < coinSpawnCol; i++)
        {
            GameObject Coin = Instantiate(coinPrefab, coinSpawnPoint[i].transform);
        }
    }

    private void FisherSort()
    {
        for (int i = 0; i < coinSpawnPoint.Length; i++)
        {
            GameObject temp = coinSpawnPoint[i];
            int randomIndex = Random.Range(i, coinSpawnPoint.Length);
            coinSpawnPoint[i] = coinSpawnPoint[randomIndex];
            coinSpawnPoint[randomIndex] = temp;
        }
    }
}

