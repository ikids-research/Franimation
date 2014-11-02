using UnityEngine;
using System.Collections;

public class ButtonTrigger : MonoBehaviour {
	public KeyCode triggerKey = KeyCode.Space;
	public GameObject[] triggerObjects;

	private Animator[] triggerObjectAnimators;

	// Use this for initialization
	void Start () {
		triggerObjectAnimators = new Animator[triggerObjects.Length];
		for (int i = 0; i < triggerObjects.Length; i++)
						triggerObjectAnimators [i] = triggerObjects [i].GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool trigger = Input.GetKey (triggerKey);
		foreach (Animator a in triggerObjectAnimators)
			if(a && trigger)
					a.SetTrigger(Animator.StringToHash ("NextPhase"));
	}
}
