using UnityEngine;

public class FireLightScript : MonoBehaviour
{
	public float minIntensity = 0.5f;
	public float maxIntensity = 0.6f;

	public Light fireLight;

	float random;

	void Update()
	{
		random = Random.Range(100.0f, 110.0f);
		float noise = Mathf.PerlinNoise(random, Time.time);
		fireLight.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
	}
}