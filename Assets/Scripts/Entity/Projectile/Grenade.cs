using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using EMSYS.FPS.Interface;
namespace EMSYS.FPS.Entity.Projectile
{
    public class Grenade : MonoBehaviour
    {
        [SerializeField]
        private ExplosionData data;
        private Rigidbody rigid;
        private SphereCollider sphere;
        private AudioSource audio;
        private void OnEnable()
        {
            if (!sphere)
                sphere = GetComponent<SphereCollider>();
            if (!audio)
                audio = GetComponent<AudioSource>();
            if (!rigid)
                rigid = GetComponent<Rigidbody>();
            rigid.AddForce(transform.forward * data.force, ForceMode.Impulse);
            StartCoroutine(ExplodeAfter(data.time));
        }
        private IEnumerator ExplodeAfter(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Explode();
        }
        private IEnumerator DestroyAfter(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
        public void Explode()
        {
            audio.Play();
            // Explode the grenade
            Collider[] colliders = Physics.OverlapSphere(transform.position, data.radius);
            foreach (Collider collider in colliders)
            {
                float distance = Vector3.Distance(transform.position, collider.transform.position);
                int damage = (int)Mathf.Lerp(data.maxDamage, data.minDamage, distance / 5f);
                collider.TryGetComponent(out IEntity entity);
                if (entity != null)
                    entity.Damage(damage);
            }
            StartCoroutine(DestroyAfter(3f));
        }
    }
}
