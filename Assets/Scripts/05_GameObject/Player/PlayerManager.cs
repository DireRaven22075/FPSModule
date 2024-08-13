using UnityEngine;
using EMSYS.FPS.Interface;
public class PlayerManager : MonoBehaviour
{

    /// <summary>
    /// 1. 투척물 (수류탄, 연막탄?) **완료**
    /// 2. 포탈 (발로란트) **제작중**
    /// 3. 총 **완료**
    /// 4. 근접무기 **완료**
    /// 5. 무기교체 **완료**
    /// 5. Toggle
    /// 6. 조준경 구현
    /// 7. UI
    /// 8. 날씨?
    /// 9. 발자국 소리
    /// 10. 미니맵
    /// 11. 적 AI (Boomer, Hunter)
    /// 12. 파괴가능한 오브젝트
    /// 
    /// </summary>
    public int health { get; set; }
    public void Damage(int value)
    {
        health -= value;
        if (health <= 0) Die();
    }
    public void Die() => Destroy(this.gameObject);
    Vector3 dir;

    Animator anim;
    CharacterController cc;
    Camera pov;
    float yRotation = 0;
    public AudioClip footstep;
    public float speed;
    private void Start()
    {
        health = 100;
        Cursor.lockState = CursorLockMode.Locked;
        anim = GetComponent<Animator>(); 
        cc = GetComponent<CharacterController>();
        pov = GetComponentInChildren<Camera>();
    }
    private void Update()
    {
        Ray ray = new Ray(pov.transform.position, pov.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            if (hit.transform.GetComponent<IEntity>() != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.GetComponent<IEntity>().Damage(100);
                }
            }
        }
        float y = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * 3;
        yRotation -= Input.GetAxis("Mouse Y") * 3;

        yRotation = Mathf.Clamp(yRotation, -90, 90);

        transform.localEulerAngles = new Vector3(0, y, 0);
        pov.transform.localEulerAngles = new Vector3(yRotation, 0, 0);
        if (cc.isGrounded)
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            dir = new Vector3();
            dir += transform.forward * Input.GetAxis("Vertical"); 
            dir += transform.right * Input.GetAxis("Horizontal");
            dir *= speed;


            if (Input.GetKeyDown(KeyCode.Space))
                dir.y = 3.5f;
        }
        dir.y += Physics.gravity.y * Time.deltaTime;
        cc.Move(dir * Time.deltaTime);
    }
}