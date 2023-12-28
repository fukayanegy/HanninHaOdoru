using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardBase : ScriptableObject
{
    // card information datas
    [SerializeField] string cardName;
    [SerializeField] CardTypes cardType;
    [TextArea]
    [SerializeField] string description;

    public string CardName { get => cardName; }
    public CardTypes CardType { get => cardType; }
    public string Description { get => description; }
}

public enum CardTypes
{
    Tantei,
    Hannin,
    Daiitihakkensya,
    Aribai,
    Torihiki,
    Jyouhousousa,
    Uwasa,
    Takurami,
    Ippanjin,
    Syounen,
    Inu,
}