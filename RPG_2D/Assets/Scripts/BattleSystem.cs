using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unity enemyUnit;
    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }
    void SetupBattle()
    {
       
       GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerGO.GetComponent<U>();
        Instantiate(enemyPrefab, enemyBattleStation);
    }
}
