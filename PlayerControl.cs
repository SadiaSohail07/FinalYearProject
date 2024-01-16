using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private const string WalkTrigger = "Walk";
    private const string RunTrigger = "Run";
    private const string IdleJumpTrigger = "IdleJump";
    private const string RunJumpTrigger = "RunJump";
    private const string GunFireTrigger = "GunFire";
    private const string GunReloadTrigger = "GunReload";
    private const string DieTrigger = "Die";
    private const KeyCode WalkKey = KeyCode.W;
    private const KeyCode RunKey = KeyCode.LeftShift;
    private const KeyCode JumpKey = KeyCode.Space;
    private const KeyCode FireKey = KeyCode.F;
    private const KeyCode ReloadKey = KeyCode.R;
    private const KeyCode DieKey = KeyCode.D;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        HandleMovement();
        HandleJump();
    HandleGunActions();
        HandleDie();
    }
    private void HandleMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(RunKey))
        {
            animator.SetTrigger(RunTrigger);
        }
        else if (Input.GetKey(WalkKey))
        {
            animator.SetTrigger(WalkTrigger);
        }
    }
    private void HandleJump()
    {
        if (Input.GetKeyDown(JumpKey))
        {
            if (Input.GetKey(RunKey))
            {
                animator.SetTrigger(RunJumpTrigger);
            }
            else
            {
                animator.SetTrigger(IdleJumpTrigger);
            }
        }
    }
    private void HandleGunActions()
    {
        if (Input.GetKeyDown(FireKey) || Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger(GunFireTrigger);
        }
        if (Input.GetKeyDown(ReloadKey) || Input.GetMouseButtonDown(1))
    {
            animator.SetTrigger(GunReloadTrigger);
        }
    }
    private void HandleDie()
    {
        if (Input.GetKeyDown(DieKey))
        {            
            animator.SetTrigger(DieTrigger);
        }
    }
}