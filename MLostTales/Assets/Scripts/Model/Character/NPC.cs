using UnityEngine;
using System;

/* Class which represents every NPC in the game linked or not to some quests
* Date : 03/08/2022
* Author : DOMPEY Fabien
* Version : 1.0.0
*/
[Serializable]
[CreateAssetMenu(menuName = "Character/NPC")]
public class NPC : Character{

    [SerializeField] private List<string> _dialogs;
    private int _currentStep = 0;

    //Tells the NPC he must now get to the next dialog (see Quest system)
    public void nextStep(){
        _currentStep++;
    }

    //Gets current dialog of the NPC
    public string getCurrentDialog(){
        return _dialogs[_currentStep];
    }

    public NPC(string name,string desc,List<string> dial) : base(name,desc){
        _dialogs = new List<string>(dial);
    }

}