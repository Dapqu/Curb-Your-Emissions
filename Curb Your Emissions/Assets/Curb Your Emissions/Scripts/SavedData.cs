using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavedData
{
    public float gold;
    public float emission;
    public float power;
    public float goldPerTick;
    public float emissionPerTick;
    public float powerPerTick;
    public float maxPower;
    public float maxEmission;
    public float timeSpent;

    public SavedData (GameManager gameManager) {
        gold = gameManager.gold;
        emission = gameManager.emission;
        power = gameManager.power;
        goldPerTick = gameManager.goldPerTick;
        emissionPerTick = gameManager.emissionPerTick;
        powerPerTick = gameManager.powerPerTick;
        maxPower = gameManager.maxPower;
        maxEmission = gameManager.maxEmission;
    }

    public SavedData (Timer timer) {
        timeSpent = timer.timeSpent;
    }
}
