using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreTracker : MonoBehaviour
{
    static public TextMeshProUGUI countText;
    static public TextMeshProUGUI countPone; 
    static public TextMeshProUGUI countPtwo;
    static public GameObject winTextObject;
    private static bool ScA = false;
    private static bool ScB = false;
    int wincount = 0;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);        
    }
    // Update is called once per frame
    void Update()
    {        
    }
    public static void ScoreTickerPone(int score1)
    {
        if (score1 == 6)
        {
            ScA = true;
            SetCountText1(score1);
            score1 = 7;
        }
        else
        {
            SetCountText1(score1);
        }
    }
    public static void ScoreTickerPtwo(int score2)
    {
        if (score2 == 6)
        {

            ScB = true;
            SetCountText2(score2);
            score2 = 7;
        }
        else
        {
            SetCountText2(score2);
        }
    }
    void ScoreTickerMain()
    {
        
    }
    static void SetCountText1(int count)
    {
        countText.text = "Count: " + count.ToString();
        if (ScA && ScB)
        {
            winTextObject.SetActive(true);
        }
    }
    static void SetCountText2(int count)
    {
        countText.text = "Count: " + count.ToString();
        if (ScA && ScB)
        {
            winTextObject.SetActive(true);
        }
    }
}
