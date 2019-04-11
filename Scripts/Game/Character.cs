using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private float maxHP;

    [SerializeField]
    private Bullet bullet;

    [SerializeField]
    private int numerobalas;

    [SerializeField]
    private float shootForce = 20F;

    [SerializeField]
    private Transform bulletSpawnPosition;

    private Bullet[] Bullets;
    private int ActualBullet;

    private float hp;

    public float HP
    {
        get { return hp; }
        protected set { hp = value; }
    }

    public float ShootForce { get { return shootForce; } }

    public void ModifyHP(float delta)
    {
        HP += delta;

        if (HP <= 0F)
        {
            OnDeath();
        }
    }

    protected virtual void OnDeath()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        CreatePool();
        HP = maxHP;
    }

    protected void SpawnBullet()
    {
        if (bullet != null && bulletSpawnPosition != null)
        {
            Instantiate<Bullet>(bullet, bulletSpawnPosition.position, transform.rotation).Shoot(this);
        }
    }

    protected void ShootActualBullet()
    {
        Bullet ActualBullet = GetNextBullet();
        ActualBullet.transform.position = bulletSpawnPosition.position;
        ActualBullet.transform.rotation = transform.rotation;
        ActualBullet.Shoot(this);
    }

    public void CreatePool()
    {
        Bullets = new Bullet[numerobalas];
        for (int i = 0; i < numerobalas; i++)
        {
            Bullet instanciabala = GameObject.Instantiate(bullet, new Vector3(i, 0, 100), Quaternion.identity);
            Bullets[i] = instanciabala.GetComponent<Bullet>();
        }
    }

    public Bullet GetNextBullet()
    {
        ActualBullet++;
        if (ActualBullet >= numerobalas)
        {
            ActualBullet = 0;
        }
        return Bullets[ActualBullet];
    }
}