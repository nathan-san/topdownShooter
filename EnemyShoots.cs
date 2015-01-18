using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
	private float reloadtime;
	public float timeToReload;
	public GameObject bulletPrefab;
	public float shootingRange;
	private Transform turret;
	private Transform rotler;
	void Start () {
		reloadtime = 0;

		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform>();
		foreach (Transform t in transforms) 
		{
			if(t.gameObject.name == "turret")
			{
				turret = t;
			}
			if(t.gameObject.name == "rotler")
			{
				rotler = t;
			}
		}
	}
	

	void Update () {
		reloadtime += Time.deltaTime;
		if (reloadtime >= timeToReload)
		{
			CheckForPlayer();

		}
	}
	private void CheckForPlayer()
	{
		Ray myRay = new Ray ();
		myRay.origin = turret.position;
		myRay.direction = turret.forward;

		RaycastHit hitInfo;

		if (Physics.Raycast (myRay, out  hitInfo, shootingRange)) 
		{
			print(hitInfo.collider.gameObject.name);
			string hitObjectName = hitInfo.collider.gameObject.name;


			if(hitObjectName == "Tank")
			{
				Instantiate(bulletPrefab,  rotler.position, rotler.rotation);

				reloadtime = 0f;
			}
		}
	}
}
