using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public GameObject pervi;
	public GameObject back;
	public void next()
	{
		pervi.transform.localPosition = new Vector3(0, 0, 0);
		back.transform.localPosition = new Vector3(-768, 0, 0);
	}
}
