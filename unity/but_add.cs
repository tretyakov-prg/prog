using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class but_add : MonoBehaviour {

	public GameObject MyRowPrefab;
	public GameObject ScrollViewObject;

	public string[] namePlayer = null;

	public void Start()
	{
		///if (namePlayer.Length != 0) 
		//{
			//foreach (string paler in namePlayer) 
			//{
		MyRowPrefab = GameObject.Find("FIO");
		Debug.Log (MyRowPrefab);
				GameObject newObj = Instantiate (MyRowPrefab);
				newObj.transform.SetParent (ScrollViewObject.transform, false);
				//Debug.Log (paler);
			//}
		//}
		//Debug.Log (namePlayer.Length);
	}

	public void _add(string test = null)
	{
		ItemDetails newUser = new ItemDetails ();
		newUser._text.text = test;//_add (test);
		//Debug.Log(test);
		//GameObject newObj = Instantiate (MyRowPrefab);
		//newObj.transform.SetParent (ScrollViewObject.transform, false);
		//Debug.Log (newUser._text.text);
	}
}
