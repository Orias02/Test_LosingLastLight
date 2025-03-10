using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textHealthPlayer;
    public TextMeshProUGUI textHealthEnemy;
    public Character textHealth;
    public Character textEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textHealthPlayer.text = "Player hp: " + textHealth.healthCharacter;
        textHealthEnemy.text = "Enemy hp: " + textEnemy.healthCharacter;
    }
}
