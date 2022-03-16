using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ATM : MonoBehaviour
{
    public int balance;
    public int changeAmount;
    public TextMeshProUGUI currentBalance;
    // Start is called before the first frame update
    void Start()
    {
        currentBalance.text = "$" + balance;
    }

    // Update is called once per frame
    void Update()
    {
        currentBalance.text = "$" + balance;
    }
    
    public void BalanceChangeUp()
    {
        balance += changeAmount;
        Debug.Log(balance);
    }
    public void BalanceChangeDown()
    {
        balance -= changeAmount;
        Debug.Log(balance);
    }

}
