using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public override void OnRootScreenBack ()
	{
		base.OnRootScreenBack ();
		TwoChoiceDialog twoChoiceDialog = (TwoChoiceDialog)DialogBuilder.Create (DialogBuilder.DialogType.CHOICE_DIALOG);
		twoChoiceDialog.SetMessage ("Exit the application?");
		twoChoiceDialog.SetOnConfirmListener (() => {
			Application.Quit();
		});
	}
}
