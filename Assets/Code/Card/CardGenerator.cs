using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カードを生成するためのクラス
/// </summary>
public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardPrefab;

    private void Start()
    {
        SpawnCards(3);
    }

    /// <summary>
    /// 複数枚カードPrefabを生成するための関数
    /// </summary>
    /// <param name="numberOfCards">生成したいカードの枚数</param>
    public void SpawnCards(int numberOfCards)
    {
        int cardCode;

        for (int i=0; i < numberOfCards; i++)
        {
            cardCode = Random.Range(0, 4);
            SpawnCard(cardCode);
        }
        return ;
    }

    /// <summary>
    /// 指定したカード番号のカードPrefabを生成する関数
    /// </summary>
    /// <param name="cardCode">生成したいカードのコード</param>
    public void SpawnCard(int cardCode)
    {
        Card card = Instantiate(cardPrefab);
        card.Set(cardBases[cardCode]);
        return ;
    }
}
