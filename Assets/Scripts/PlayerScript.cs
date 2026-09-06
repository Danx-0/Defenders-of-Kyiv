using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public InputAction avmovement;
    public InputAction FireMov;
    public Rigidbody2D r2D;
    public int lifes;

    [SerializeField] GameObject Bullet;

    [SerializeField] private AudioSource shootAu;

    private void FixedUpdate()
    {  
        //vector 2 es para definir la direccion y la cantidad de movimiento.
        //ClampMagnitude es para limitar las cantidades dichas en el vector y que no pasen de ese rango dado.
        Vector2 movement = avmovement.ReadValue<Vector2>();
        r2D.linearVelocity = movement * 8;
        r2D.linearVelocity = Vector2.ClampMagnitude(r2D.linearVelocity, 10);
    }

    private void OnEnable()
    {
        avmovement.Enable();
        FireMov.Enable();
    }

    private void OnDisable()
    {
        avmovement.Disable();
        FireMov.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lifes = 3;
        shootAu = GetComponent<AudioSource>();
        GameManager.instance.UpdateLifes(lifes);
    }

    // Update is called once per frame
    void Update()
    {
        


        Vector3 lim = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        float x = Mathf.Clamp(transform.position.x, -lim.x + 0.5f, lim.x - 0.5f);
        float y = Mathf.Clamp(transform.position.y, -lim.y + 0.5f, lim.y - 0.5f);
        transform.position = new Vector3(x, y, transform.position.z);


        if (FireMov.WasPressedThisFrame()) 
        {

           Instantiate(Bullet, transform.position, Quaternion.identity);
           shootAu.Play();
        }

        
    }
    
    public void TakeDamage()
    {
        lifes--;
        GameManager.instance.UpdateLifes(lifes);   

        if (lifes <= 0)
        {
            GameManager.instance.OpenGameOver();
            gameObject.SetActive(false);    
        }
    }

    
}