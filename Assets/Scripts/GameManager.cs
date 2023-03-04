using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverPannel;
    public TMP_Text pointsText;
    public bool gameRunning;

    private int points;

    private static GameManager instance;

    void Start()
    {
        instance = this;
        gameRunning = true;
    }

    void Update()
    {

    }

    public static bool isRunning()
    {
        return instance.gameRunning;
    }

    public static void GainPoint()
    {
        instance.points++;
        instance.pointsText.text = instance.points + "";
    }

    public static void Lose()
    {
        instance.gameRunning = false;
        instance.gameOverPannel.SetActive(true);
        Debug.Log("AUA");
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

}
