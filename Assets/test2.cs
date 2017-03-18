using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;
	private int syouhi = 5;

	public void Magic(){
		if(mp > 5){
			int nokori = mp - syouhi;
			Debug.Log("魔法攻撃をした。残りMPは" +nokori+"。");
			mp = nokori;
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

}

public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastBoss = new Boss ();
		for (int i = 0; i < 11; i++) {
			lastBoss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
