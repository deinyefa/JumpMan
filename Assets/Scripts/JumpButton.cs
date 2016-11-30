using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public void OnPointerDown (PointerEventData data) {
		if (PlayerJump.instance != null) {
			PlayerJump.instance.SetPower (true); 
		}
	}

	public void OnPointerUp (PointerEventData data) {
		if (PlayerJump.instance != null) {
			PlayerJump.instance.SetPower (false); 
		}
	}

}
