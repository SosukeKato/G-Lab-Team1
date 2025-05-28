using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] Text descriotionText;
    [SerializeField] Text CountText;

    

    public EnemyBase Base { get; private set; }
    public EnemyBase Status { get; private set; }
    public Text DescriotionText { get => descriotionText; set => descriotionText = value; }
    public Text CountText1 { get => CountText; set => CountText = value; }

    private EnemyLifeContlloer enemyLifeContlloer;
    public EnemyLifeContlloer EnemyLifeContlloer { get => enemyLifeContlloer; set => enemyLifeContlloer = value; }

    public int poisonDuration = 0;
    public int poisonDamagePerTurn = 0;
    public int PoisonDuration
    {
        get => poisonDuration;
        set => poisonDuration = Mathf.Max(0, value);
    }

    public UnityAction<Card> OnClickCard;

    

    //カード内容の定義
    public void SetEnemy(EnemyBase enemyBase)
    {
        enemyBase.EnemyLife = enemyBase.EnemyLifeMax;
        enemyBase.Count1 = enemyBase.EnemyCount;
        Base = enemyBase;
        icon.sprite = enemyBase.Icon;
        descriotionText.text = enemyBase.Description;
        CountText1.text = $"{enemyBase.Count1}";
        EnemyLifeContlloer = GetComponent<EnemyLifeContlloer>();

        PoisonDuration = 0;
    }



}
