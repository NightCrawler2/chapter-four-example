using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float Speed = 3.0f;
    public float MaxZ = 16.0f;
    public float MinZ = -16.0f;

    private int _direction = 1;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		transform.Translate(0, 0, _direction * Speed * Time.deltaTime);

	    var bounced = false;
	    if (transform.position.z > MaxZ || transform.position.z < MinZ)
	    {
	        _direction *= -1;
	        bounced = true;
	    }
	    if (bounced)
	    {
	        transform.Translate(0,0, _direction * Speed * Time.deltaTime);
	    }
	}
}
