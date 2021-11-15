using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI goldText;
    [SerializeField]
    private TextMeshProUGUI emissionText;
    [SerializeField]
    private TextMeshProUGUI powerText;
    [SerializeField]
    private PowerBar powerBar;
    [SerializeField]
    private EmissionBar emissionBar;
    public Timer timer;

    public float gold;
    public float goldPerTick;
    public float emission;
    public float maxEmission = 150f;
    public float emissionPerTick;
    public float power;
    public float maxPower = 100f;
    public float powerPerTick;

    void Start() {
        //LoadGame();
        TimeTickSystem.Create();

        gold = emission = power = 0f;
        goldPerTick = emissionPerTick = powerPerTick = 0f;
        
        emissionBar.SetMaxEmission(maxEmission);
        powerBar.SetMaxPower(maxPower);

        TimeTickSystem.OnTick += delegate (object sender, TimeTickSystem.OnTickEventArgs e) {
            UpdateGold();
            UpdateEmission();
            UpdatePower();

            goldText.text = gold.ToString();
            emissionText.text = emission.ToString() + "/" + maxEmission.ToString();
            powerText.text = power.ToString() + "/" + maxPower.ToString();
        };
    }

    public void ChangeGoldPerTick() {
        goldPerTick++;
    }

    public void UpdateGold() {
        gold += goldPerTick;
    }

    public void ChangeEmissionPerTick() {
        emissionPerTick++;
    }

    public void UpdateEmission() {
        emission += emissionPerTick;
        emissionBar.SetEmission(emission);
    }

    public void ChangePowerPerTick() {
        powerPerTick++;
    }

    public void UpdatePower() {
        power += powerPerTick;
        powerBar.SetPower(power);
    }

    public void SaveGame() {
        SaveSystem.SaveGameManager(this);
    }

    public void LoadGame() {
        SavedData data = SaveSystem.LoadGameManagerData();

        gold = data.gold;
        emission = data.emission;
        power = data.power;
        goldPerTick = data.goldPerTick;
        emissionPerTick = data.emissionPerTick;
        powerPerTick = data.powerPerTick;
        maxPower = data.maxPower;
        maxEmission = data.maxEmission;
    }
}
