using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {
	public float maxLife;
	private float lifeTime;
	private Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity -= 0.1f;

		lifeTime += Time.deltaTime;
		if (lifeTime > maxLife) 
		{
			Destroy(this.gameObject);
		}
	}
}
