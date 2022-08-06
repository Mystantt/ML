using UnityEngine;
using System;

/* Class of all characters in the game
*   Date : 03/08/2022
*   Author : DOMPEY Fabien
*   Version : 1.0.0
*/
[Serializable]
public abstract class Character : ScriptableObject{

    [SerializeField] private string _name;
    [TextArea] private string _description;

    public string Name{ get => _name; }
    public string Description{ get => _description; set => _description = value; }

    public Character(string name,string description){
        _name = name;
        _description = description;
    }
}