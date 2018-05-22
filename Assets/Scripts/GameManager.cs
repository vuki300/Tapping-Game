using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UnityEngine.UI.Text moneyText;
    public UnityEngine.UI.Text clickMPText;
    public UnityEngine.UI.Text clickINCText;
    public UnityEngine.UI.Text idleMPText;
    public UnityEngine.UI.Text idleINCText;
    public UnityEngine.UI.Text bulkText;
    public UnityEngine.UI.Text Store01Text;
    public UnityEngine.UI.Text Store11Text;
    public UnityEngine.UI.Text Store02Text;
    public UnityEngine.UI.Text Store12Text;
    public UnityEngine.UI.Text Store03Text;
    public UnityEngine.UI.Text Store13Text;
    public UnityEngine.UI.Text Store04Text;
    public UnityEngine.UI.Text Store14Text;
    public UnityEngine.UI.Text Store05Text;
    public UnityEngine.UI.Text Store15Text;
    public UnityEngine.UI.Text Store06Text;
    public UnityEngine.UI.Text Store16Text;
    public UnityEngine.UI.Text Store07Text;
    public UnityEngine.UI.Text Store17Text;
    public UnityEngine.UI.Text Store08Text;
    public UnityEngine.UI.Text Store18Text;
    public GameObject Select;
    public GameObject MainScene;
    public GameObject Store;
    public GameObject StoreButton;
    public GameObject Store1;
    private int money;
    private int clickMP = 1;
    private int clickINC = 5;
    private int idleMP = 1;
    private int idleINC = 0;
    private int bulk = 1;
    private int price01 = 100;
    private int owned01;
    private int price11 = 1000;
    private int owned11;
    void Start()
    {
        Select.SetActive(true);
        MainScene.SetActive(false);
        Store.SetActive(false);
        StoreButton.SetActive(true);
        Store1.SetActive(false);
        clickMPText.text = "Click Multiplier: " + clickMP + "X";
        clickINCText.text = "Per Click: " + clickINC;
        idleINCText.text = "Per Frame: " + idleINC;
        idleMPText.text = "Idle Multiplier: " + idleMP + "X";
        bulkText.text = "Selected: " + bulk;
        Store01Text.text = owned01 + " | $" + price01 * bulk;
        Store02Text.text = "To be added";
        Store03Text.text = "To be added";
        Store04Text.text = "To be added";
        Store05Text.text = "To be added";
        Store06Text.text = "To be added";
        Store07Text.text = "To be added";
        Store08Text.text = "To be added";
        Store11Text.text = owned11 + " | $" + price11 * bulk;
        Store12Text.text = "To be added";
        Store13Text.text = "To be added";
        Store14Text.text = "To be added";
        Store15Text.text = "To be added";
        Store16Text.text = "To be added";
        Store17Text.text = "To be added";
        Store18Text.text = "To be added";

    }
// Update per frame
   void Update()
    {
        moneyText.text = "Money: " + money;
        money += (idleMP * idleINC);
    }
    public void Held()
    {
        money += (clickINC * clickMP);

    }
//MENUS
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
    public void unlokstor()
    {
        if (money >= 100) {
            Store1.SetActive(true);
            StoreButton.SetActive(false);
            money -= 100;
            idleINC = 1;
            idleMP = 1;
            idleINCText.text = "Per Frame: " + idleINC;

        }
    }
    //store ui
    public void bulk1 ()
    {
        bulk = 1;
        bulkText.text = "Selected: " + bulk;
        Store01Text.text = owned01 + " | $" + price01 * bulk;
        Store11Text.text = owned11 + " | $" + price11 * bulk;
    }
    public void bulk10 ()
    {
        bulk = 10;
        bulkText.text = "Selected: " + bulk;
        Store01Text.text = owned01 + " | $" + price01 * bulk;
        Store11Text.text = owned11 + " | $" + price11 * bulk;
    }
    public void bulk100 ()
    {
        bulk = 100;
        bulkText.text = "Selected: " + bulk;
        Store01Text.text = owned01 + " | $" + price01 * bulk;
        Store11Text.text = owned11 + " | $" + price11 * bulk;
    }
    public void store01()
    {
        if(price01 * bulk <= money)
        {
            clickINC += 5 * bulk;
            money -= price01 * bulk;
            price01 += ((price01/100)*10) * bulk;
            owned01 += bulk;
            Store01Text.text = owned01 + " | $" + price01 * bulk;
            clickINCText.text = "Per Click: " + clickINC;
        }
    }
    public void store11()
    {
        if(price11 * bulk <= money)
        {
            clickMP += 1 * bulk;
            money -= price11 * bulk;
            price11 += ((price01 / 100) * 10) * bulk;
            owned11 += bulk;
            Store11Text.text = owned11 + " | $" + price11 * bulk;
            clickMPText.text = "Click Multiplier: " + clickMP + "X";
        }
    }
       
}
