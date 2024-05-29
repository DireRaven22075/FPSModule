using System.Collections;
using System.Collections.Generic;
using EMSYS.FPS.Entity;
using EMSYS.FPS;
using UnityEngine;
using UnityEngine.UI;
public class WeaponUI : MonoBehaviour
{
    private Player player;
    private Text text;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        text = GetComponent<Text>();
    
    }

    void Update()
    {
        WeaponData weapon = player.weapons[player.weaponIndex - 1];
        text.text = string.Format("{0}\n{1} / {2}", weapon.name, weapon.loadedAmmo, weapon.ammo);
    }
}
