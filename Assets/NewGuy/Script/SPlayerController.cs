using UnityEngine;
using System.Collections;


[System.Serializable]
public class lotsOfstuff
{
	public float stuff;
	public float moreStuff;
	public float minX, minZ, maxX, maxZ;
}

public class NewBehaviourScript : MonoBehaviour 
{
	void Start()
	{
		gameObject.AddComponent<LineRenderer> ();
	}

}
