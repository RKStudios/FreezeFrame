using UnityEngine;
using System.Collections;

public class FrozenPlayer : MonoBehaviour {

	public GameObject deathParticles;

	public void Die()
	{
		Instantiate (deathParticles, transform.position, Quaternion.Euler (270, 0, 0));
		Destroy(this.gameObject);
	}
}
