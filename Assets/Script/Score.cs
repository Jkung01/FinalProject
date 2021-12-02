using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public float timeLeft = 60;
    public GameObject timeUI;
    public GameObject ScoreUI;
    private AudioSource au;
    public AudioClip coinClip;
    void Start()
    {
        
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text=""+(int)timeLeft;
        ScoreUI.gameObject.GetComponent<Text>().text = "" + (int)score;

        if (timeLeft<0.1f)
        {
            SceneManager.LoadScene(5);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.tag=="Meat")
        {
            score += 1;
            Destroy(other.gameObject);
            
        }
    }
}
