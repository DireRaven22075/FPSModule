using UnityEngine;
using EMSYS.FPS.Interface;
public class ExplosionBarrel : MonoBehaviour
{
    public float explosionRadius = 5f;
    public int damageAmount = 10;

    //거리에 따른 대미지 감소
    private void Explode()
    {
        Debug.Log(Mathf.Lerp(0, damageAmount, 1- Vector3.Distance(transform.position, transform.position) / explosionRadius));
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider collider in colliders)
        {
            Ray ray = new Ray(transform.position, collider.transform.position - transform.position);
            if (Physics.Raycast(ray, out RaycastHit hit, explosionRadius))
            {
                if (hit.collider != collider)
                {
                    continue;
                }
            }
            IEntity entity = collider.GetComponent<IEntity>();
            if (entity != null)
            {
                entity.Damage(damageAmount);
            }
        }
    }
}