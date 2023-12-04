using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialCredit : MonoBehaviour
{
    public Text socialCreditText;
    public int socialCredit = 0;

    public void UpdateCredit(int toAdd)
    {
        socialCredit += toAdd;
        socialCreditText.text = "Social credit: " + socialCredit.ToString();
    }
}
