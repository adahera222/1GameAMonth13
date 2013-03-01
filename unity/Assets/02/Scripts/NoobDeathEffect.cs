using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class NoobDeathEffect : MonoBehaviour {

    public float startVelocity;
    public float startSpin;
    public float duration;

    private float startTime;

	void Start () {
        rigidbody.velocity = new Vector3(0, startVelocity, 0);
        rigidbody.angularVelocity = new Vector3(Random.Range(-startSpin, startSpin), 0, 0);
        startTime = Time.time;
	}
	void Update () {
        if(Time.time > startTime + duration) {
            Destroy(gameObject);
        }
	}
}