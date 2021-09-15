using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public Text time;
    public GameObject done;

    public GameObject square;

    float alive = 0.0f;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.3f);
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        time.text = alive.ToString("N2");
    }

    public void gameOver()
    {
        done.SetActive(true);
        Invoke("gameStop",0.5f);
    }

    void gameStop()
    {
        Time.timeScale = 0.0f;
    }
    public void retry()
    {
        Time.timeScale = 1f;
        alive = 0.0f;
        SceneManager.LoadScene("MainScene");
    }
}
