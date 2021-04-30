using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthDisplay : MonoBehaviour
{
 Text healthText;
 Player player;
 // Start is called before the first frame update
 void Start()
 {
     healthText = GetComponent<Text>();
    Debug.Log(healthText.name);
    player = FindObjectOfType<Player>();
 }
 // Update is called once per frame
 void Update()
 {
    // Debug.Log(player.GetHealth().ToString() +  " health");
    // Debug.Log(healthText.text);
    // healthText.text = "dsdsdsd";
    // Debug.Log(healthText.name);
    healthText.text = player.GetHealth().ToString();
 }
}
