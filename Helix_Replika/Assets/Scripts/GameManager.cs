using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score ;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
  
    }


    public void GameScore(int ringScore)
    {

        score = score + ringScore;
        Debug.Log(ringScore);
        scoreText.text = score.ToString();


    }

    public void Restart()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }
    




   
}
