using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LearningCurve : MonoBehaviour
{
    public bool pureOfHeart;
    public bool hasSecretIncantation;
    public string rareItem;
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character("Sniper", 15);
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha", 0);
        heroine.PrintStatsInfo();

        Weapon hungtingBowKnight = new Weapon("Hunting Bow Knight", 150);
        hungtingBowKnight.PrintWeaponsStats();

        Character hero2 = new Character("hero2=hero");
        hero2.PrintStatsInfo();
        hero2 = hero;
        hero2.PrintStatsInfo();
        hero2.name = "Minion";
        hero2.PrintStatsInfo();

        hero2.name = "Keks";
        hero2.PrintStatsInfo();

        hero.PrintStatsInfo();

        Weapon huntingBow1 = new Weapon("Hunting Bow", 7);
        Weapon warBow = hungtingBowKnight;

        huntingBow1.PrintWeaponsStats();
        warBow.PrintWeaponsStats();

        warBow.name = "peaceBow";
        warBow.PrintWeaponsStats();

        Paladin knight = new Paladin("Knight Arthas", hungtingBowKnight);
        knight.PrintStatsInfo();

        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
