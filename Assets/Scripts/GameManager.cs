using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UnityEngine.UI.Text moneyText;
    public GameObject Select;
    public GameObject MainScene;
    public GameObject Store;
    private int money;
    private int clickMP;
    private int clickINC;
    private int idleMP;
    private int idleINC;
    void Start()
    {
        clickMP = 1;
        clickINC = 1;
        idleMP = 0;
        idleINC = 1;
        Select.SetActive(true);
        MainScene.SetActive(false);
        Store.SetActive(false);
        
    }

   void Update()
    {
        moneyText.text = "Money: " + money;
    }
    public void Held()
    {
        money += (clickINC * clickMP);
    }
    public void slct()
    {
        Select.SetActive(true);
        MainScene.SetActive(false);
        Store.SetActive(false);
    }
    public void mein()
    {
        MainScene.SetActive(true);
        Store.SetActive(false);
        Select.SetActive(false);
    }
    public void stor()
    {
        Store.SetActive(true);
        MainScene.SetActive(false);
        Select.SetActive(false);
    }

}
