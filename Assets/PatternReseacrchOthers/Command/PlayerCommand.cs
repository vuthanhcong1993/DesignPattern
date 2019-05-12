using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Receiver+Invoker
public class PlayerCommand : MonoBehaviour {

    private ICommandNew immortal;
    private ICommandNew invisible;
    private ICommandNew ultimate;

	// Use this for initialization
	void Start () {
        immortal = new PlayerImmortal();
        invisible = new PlayerInvisible();
        ultimate = new PlayerUltimate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Receiver here
    public void ExecuteCommand()
    {

    }
   // Invoker here
    void Use()
    {
        immortal.Execute(this);
        invisible.Execute(this);
        ultimate.Execute(this);
    }
}
