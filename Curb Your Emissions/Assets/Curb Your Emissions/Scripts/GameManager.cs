using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    private const string SAVE_SEPARATOR = "\n";
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

    public float gold = 5000000f;
    public float goldPerTick = 1;
    public float emission;
    public float maxEmission = 800f;
    public float emissionPerTick;
    public float power;
    public float maxPower = 1000f;
    public float powerPerTick;

    public GameObject coal;
    public GameObject geo;
    public GameObject hydro;
    public GameObject nuclear;
    public GameObject solar;
    public GameObject wind;

    void Start() {
        TimeTickSystem.Create();
        Load();
        emissionBar.SetMaxEmission(maxEmission);
        powerBar.SetMaxPower(maxPower);

        TimeTickSystem.OnTick += delegate (object sender, TimeTickSystem.OnTickEventArgs e) {
            UpdateGold();
            UpdateEmission();
            UpdatePower();

            goldText.text = "$" + gold.ToString();
            emissionText.text = emission.ToString() + "/" + maxEmission.ToString();
            powerText.text = power.ToString() + "/" + maxPower.ToString();
        };
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            ChangePowerPerTick(1f);
            ChangeEmissionPerTick(0.82f);
            ChangeGold(-1000f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            ChangePowerPerTick(2f);
            ChangeEmissionPerTick(0.5f);
            ChangeGold(-2000f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            ChangePowerPerTick(1f);
            ChangeEmissionPerTick(0.24f);
            ChangeGold(-1500f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            ChangePowerPerTick(5f);
            ChangeEmissionPerTick(0.6f);
            ChangeGold(-1000000f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            ChangePowerPerTick(3f);
            ChangeEmissionPerTick(1.5f);
            ChangeGold(-100000f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            ChangePowerPerTick(1f);
            ChangeEmissionPerTick(0.1f);
            ChangeGold(-1000f);
        }
    }

    public void ChangeGoldPerTick(float amount) {
        goldPerTick = goldPerTick + amount;
    }

    public void UpdateGold() {
        gold += goldPerTick;

    }

    public void ChangeGold(float amount) {
        gold = gold + amount;
    }

    public void ChangeEmissionPerTick(float amount) {
        emissionPerTick = emissionPerTick + amount;
    }

    public void UpdateEmission() {
        emission += emissionPerTick;
        emissionBar.SetEmission(emission);
    }

    public void ChangePowerPerTick(float amount) {
        powerPerTick = powerPerTick + amount;
    }

    public void UpdatePower() {
        power += powerPerTick;
        powerBar.SetPower(power);
    }

    public void Save() {
        string[] contents = new string[] {
            ""+gold,
            ""+emission,
            ""+power,
            ""+goldPerTick,
            ""+emissionPerTick,
            ""+powerPerTick,
            ""+timer.timeSpent,
            ""+coal.transform.position.x,
            ""+coal.transform.position.y,
            ""+geo.transform.position.x,
            ""+geo.transform.position.y,
            ""+hydro.transform.position.x,
            ""+hydro.transform.position.y,
            ""+nuclear.transform.position.x,
            ""+nuclear.transform.position.y,
            ""+solar.transform.position.x,
            ""+solar.transform.position.y,
            ""+wind.transform.position.x,
            ""+wind.transform.position.y,
        };

        string saveString = string.Join(SAVE_SEPARATOR, contents);
        File.WriteAllText(Application.dataPath + "/save.txt", saveString);
    }

    void Load() {
        if (File.Exists(Application.dataPath + "/save.txt")) {
            string saveString = File.ReadAllText(Application.dataPath + "/save.txt");
            string[] contents = saveString.Split(new[] {SAVE_SEPARATOR}, System.StringSplitOptions.None);

            gold = float.Parse(contents[0]);
            emission = float.Parse(contents[1]);
            power = float.Parse(contents[2]);
            goldPerTick = float.Parse(contents[3]);
            emissionPerTick = float.Parse(contents[4]);
            powerPerTick = float.Parse(contents[5]);
            timer.timeSpent = float.Parse(contents[6]); 

            float x = float.Parse(contents[7]);
            float y = float.Parse(contents[8]);
            coal.transform.position = new Vector3(x, y, 0f);

            x = float.Parse(contents[9]);
            y = float.Parse(contents[10]);
            geo.transform.position = new Vector3(x, y, 0f);

            x = float.Parse(contents[11]);
            y = float.Parse(contents[12]);
            hydro.transform.position = new Vector3(x, y, 0f);

            x = float.Parse(contents[13]);
            y = float.Parse(contents[14]);
            nuclear.transform.position = new Vector3(x, y, 0f);

            x = float.Parse(contents[15]);
            y = float.Parse(contents[16]);
            solar.transform.position = new Vector3(x, y, 0f);

            x = float.Parse(contents[17]);
            y = float.Parse(contents[18]);
            wind.transform.position = new Vector3(x, y, 0f);
        }
        else {
            emission = power = 0f;
            emissionPerTick = powerPerTick = 0f;
            timer.timeSpent = 0f;
        }
    }
}
