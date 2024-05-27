using UnityEngine;

[CreateAssetMenu(fileName = "ExplosionData", menuName = "ScriptableObject/FPS", order = 0)]
public class ExplosionData : ScriptableObject {
    public int maxDamage;
    public int minDamage;
    public float radius;
    public float time;
    public float force;
    public LayerMask team;
}