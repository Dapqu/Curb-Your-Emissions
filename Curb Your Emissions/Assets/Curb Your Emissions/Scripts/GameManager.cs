using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI goldText;
    [SerializeField]
    private TextMeshProUGUI emissionText;
    [SerializeField]
    private TextMeshProUGUI powerText;

    public static float gold;
    public static float goldPerTick;
    public static float emission;
    public static float emissionPerTick;
    public static float power;
    public static float powerPerTick;

    void Start() {
        TimeTickSystem.Create();

        gold = emission = power = 0f;
        goldPerTick = emissionPerTick = powerPerTick = 0f;

        TimeTickSystem.OnTick += delegate (object sender, TimeTickSystem.OnTickEventArgs e) {
            gold += goldPerTick;
            emission += emissionPerTick;
            power += powerPerTick;

            goldText.text = gold.ToString();
            emissionText.text = emission.ToString();
            powerText.text = power.ToString();

            Debug.Log("GoldPerTick: " + goldPerTick);
            Debug.Log("EmissionPerTick: " + emissionPerTick);
            Debug.Log("PowerPerTick: " + powerPerTick);

            CMDebug.TextPopupMouse("Tick: " + TimeTickSystem.GetTick());
        };
    }

    public void ChangeGoldPerTick() {
        goldPerTick++;
    }

    public void ChangeEmissionPerTick() {
        emissionPerTick++;
    }

    public void ChangePowerPerTick() {
        powerPerTick++;
    }
}
