using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [HideInInspector]
    public int id;

    [Header("Player")]
    public string playerName;
    [Multiline]
    public string littleBackStory;

    //[Range(0, 100)]
    public float health;
    [Range(10, 20)]
    public float damage;

    [Header("Weapon")]
    public string weapon1Name;
    public float weapon1Damage;
    public float weapon2Damage;
    /*
    public string shoeName;
    public int shoeSize;
    public string shoeType;
    */

    [SpaceWithImage(3)]

    public Shoe shoe;

    [ReadOnly]
    public int achievementCount = 5;
    [ReadOnly]
    public float achievementAverageTime = 0.5f;
    [ReadOnly]
    public string lastAchievement = "Blabla";

    [ReadOnlyWithColor(1, 0, 0)]
    public string bestAchievement = "You are awesome";

    //[Tooltip("n means something")]
    //public int n;
    
    // Use this for initialization
	void Start () {
        health = 50;
        playerName = RandomNameGenerator.GetRandomName();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonCallFromInspector()
    {
        playerName = RandomNameGenerator.GetRandomName();
    }

}
