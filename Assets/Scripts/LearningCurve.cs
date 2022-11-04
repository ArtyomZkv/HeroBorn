using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LearningCurve : MonoBehaviour
{
    public bool pureOfHeart;
    public bool hasSecretIncantation;
    public string rareItem;

    // Start is called before the first frame update
    void Start()
    {
        int currentMoney = 20;

        Dictionary<string, int> itemInventary = new Dictionary<string, int>()
        {
            { "M4A1", 5 },
            { "Tactical knife", 3},
            { "Bazooka", 10 }
        };

        Dictionary<string, int> deletedItems = new Dictionary<string, int>();

       // itemInventary.Add("Throwing knife", 3);

        foreach (KeyValuePair <string, int> kvp in itemInventary)
        {
            if (currentMoney >= kvp.Value)
            {
                currentMoney -= kvp.Value;
                deletedItems.Add(kvp.Key, kvp.Value);
                Debug.Log($"{kvp.Key} added to your inventory!");
            }
        }
        Debug.Log(deletedItems.Count);

        Debug.Log(CheckToDeletedItems(itemInventary, deletedItems));
    }


    // Update is called once per frame
    void Update()
    {

    }

    public int CheckToDeletedItems(Dictionary<string, int> itemInventary, Dictionary<string, int> deletedItems)
    {
        int countOfItemInventary = itemInventary.Count;
        int countOfDeletedItems = deletedItems.Count;
        int i = 0;
        try
        {
                for (int i_deleted = 0; i_deleted < countOfDeletedItems; i_deleted++)
                {
                    if (itemInventary.Keys.ElementAt(i) == deletedItems.Keys.ElementAt(i_deleted))
                    {
                        itemInventary.Remove(itemInventary.Keys.ElementAt(i));
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
        }
        catch
        {
            
        }
        return itemInventary.Count;
    }
}
