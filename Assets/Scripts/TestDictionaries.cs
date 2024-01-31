using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDictionaries : MonoBehaviour
{
    // dictionary (keytype, valuetype)
    Dictionary<string, int> BountyPirate = new Dictionary<string, int>()
    {
        { "Luffy", 30000000},
        { "Chopper", 1000}
    };
    Dictionary<string, string> CelestialDragon = new Dictionary<string, string>()
    {
        { "Saturn", "Egghead" },
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UpdateBounty("Luffy", 60000000);
            Debug.Log("PiratesCount: " + BountyPirate.Count);
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddPirate("Kuma", 34000000);
            AddPirate("Dofi", 64000000);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CelestialDragon.ContainsKey("Saturn") && CelestialDragon.ContainsValue("Egghead"))
            {
                DeletePirate("Kuma");
            }
        }
    }

    void UpdateBounty(string pirateName, int newBounty)
    {
        BountyPirate[pirateName] = newBounty;
    }

    void AddPirate(string pirateName, int bounty)
    {   
        BountyPirate.Add(pirateName, bounty);
    }

    void DeletePirate(string pirateName)
    {
        BountyPirate.Remove(pirateName);
    }
}
