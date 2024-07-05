using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterWeaponController : MonoBehaviour
{
    public TMP_Dropdown characterOptions;
    public TMP_Dropdown weaponOptions;
    public Image characterImage;
    public Image weaponImage;

    public Sprite[] characterSprites; // Array de sprites para personajes
    public Sprite[] weaponSprites;    // Array de sprites para armas

    void Start()
    {
        characterOptions = GameObject.Find("CharacterDropdown").GetComponent<TMP_Dropdown>();
        weaponOptions = GameObject.Find("WeaponDropdown").GetComponent<TMP_Dropdown>();
        characterImage = GameObject.Find("CharacterImage").GetComponent<Image>();
        weaponImage = GameObject.Find("WeaponImage").GetComponent<Image>();

        characterOptions.onValueChanged.AddListener(delegate { ChangeCharacter(); });
        weaponOptions.onValueChanged.AddListener(delegate { ChangeWeapon(); });
    }

    public void ChangeCharacter()
    {
        characterImage.sprite = characterSprites[characterOptions.value];
    }

    public void ChangeWeapon()
    {
        weaponImage.sprite = weaponSprites[weaponOptions.value];
    }
}
