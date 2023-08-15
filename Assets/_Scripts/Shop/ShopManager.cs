using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    readonly Score score;

    public Upgrade[] upgrades;
    //public int coins;

    //References
    public TMP_Text coinText;
    public GameObject shopUI;
    public PlayerController playerController; //for upgrading the player (f.ex speed)

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        coinText = score.scoreText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Upgrade
{
    public string name;
    public int cost;
    public Image image;

    public int quantity;
    public GameObject shopItemReference;
}
