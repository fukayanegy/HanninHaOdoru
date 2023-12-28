using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Text cardNameText;
    [SerializeField] Text descriptionText;

    public void Set(CardBase cardBase)
    {
        cardNameText.text = cardBase.CardName;
        descriptionText.text = cardBase.Description;
    }
}
