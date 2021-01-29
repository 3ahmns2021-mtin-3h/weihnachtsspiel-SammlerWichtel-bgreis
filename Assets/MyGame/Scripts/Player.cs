using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool collideBadGift = false;
    public bool collideGoodGift = false;
    public int points = 0;
    public GameObject WichtelObjekt;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timeText;



    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.name.Contains("GutGeschenk"))
        {
            Destroy(collision.gameObject);
            collideGoodGift = true;
            points++;
            scoreDisplay.text = points.ToString();
        }

        if (collision.name.Contains("SchlechtGeschenk"))
        {
            Destroy(collision.gameObject);
            collideBadGift = true;
            points--;
            scoreDisplay.text = points.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if (points < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
