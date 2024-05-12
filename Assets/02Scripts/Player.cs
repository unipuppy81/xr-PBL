using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Object")]
    public GameObject enemy;
    public GameObject idCard;


    [Header("Panel")]
    public GameObject WireGamePanel;
    public GameObject JigSawGamePanel;
    public GameObject PuzzlePanel;
    public GameObject Paper1Panel;
    public GameObject Paper2Panel;
    public GameObject Paper3Panel;
    public GameObject FileDummyPanel;
    public GameObject GetItemPanel;
    public GameObject panPanel2;


    [Header("Simulation Room")]
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    public GameObject Door4;
    public GameObject Door5;
    public GameObject Computer;
    public GameObject Cabinet;
    public GameObject FileDummy;
    public GameObject File1;
    public GameObject File2;
    public GameObject File3;
    public GameObject lubricant;
    static public bool isLub;
    public GameObject Telephone;
    public GameObject TelephonePanel;
    public GameObject Battery;
    static public bool isBattery;
    public bool upWallOpenbool;

    [Header("PasseageWay Second Floor")]
    public GameObject IdCard;
    static public bool isidCard;
    public GameObject WireBox;
    public GameObject FireEx;
    public GameObject ControlPanel;
    public GameObject BatteyHouse;
    public GameObject Key1;
    static public bool hasKey1;
    public GameObject tape;
    static public bool istape;

    public GameObject Key2;
    static public bool hasKey2;

    public GameObject emergencyLight2;
   


    [Header("First Floor")]
    public GameObject distBox;
    public GameObject fan;
    public GameObject kitaid;
    public GameObject Robot;
    public GameObject FinalGateL;
    public GameObject FinalGateR;


    [Header("Inventory")]
    public GameObject yesbattery;
    public GameObject nonBattery;
    public GameObject yesoil;
    public GameObject nonOil;
    public GameObject yekey;
    public GameObject nonKey;
    public GameObject yesCard;
    public GameObject nonidCard;
    public GameObject yestape;
    public GameObject nonTape;




    [Header("var")]
    public float walkSpeed;
    public float climbSpeed;
    public float jumpForce;
    public float rotateSpeed;

    public Vector3 movePoint;

    public bool jDown;
    public bool isClimbing;
    public bool isJump;
    private bool isBorder;



    [Range(0f, 90f)][SerializeField] float cameraRotationLimit = 0f;
    [Range(0f, 10f)][SerializeField] float lookSensitivity = 1f;

    //private float cameraRotationLimit;
    private float currentCameraRotationX;


    public Camera theCamera;
    private Rigidbody myRigid;



   

    private int intCabinet;
    private int intDoor1;
    private int intDoor2;
    private int intDoor3;

    void Awake()
    {
        walkSpeed = 15.0f;
        jumpForce = 20.0f;
        climbSpeed = 5.0f;
        rotateSpeed = 1.0f;
        isJump = true;
        isClimbing = false;


        isLub = false;
        isBattery = false;
        isidCard = false;
        hasKey1 = false;
        istape = false;
        upWallOpenbool = false;
    }

    void Start()
    {
        theCamera = Camera.main;
        myRigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (upWallOpenbool) {
            upWallOpen();

            }

        OnClickMouse();
    }

    void FixedUpdate()
    {
        Move();

        if (!GameManager.isPanel) {
            CharacterRotation();
            CameraRotation();
        }
        //Jump();
        FreezeRotation();
        Climb();
        StopToWall();
    }

    private void StopToWall()
    {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.green);
        isBorder = Physics.Raycast(transform.position, transform.forward, 1, LayerMask.GetMask("Wall"));
    }
    
    private void FreezeRotation()
    {
        myRigid.angularVelocity = Vector3.zero;
    }

    private void Climb()
    {
        if (isClimbing)
        {
            //UnityEngine.Debug.Log("IsClimbing");
            float verticalInput = Input.GetAxis("Vertical");  // 수직 입력 받기
            if(verticalInput > 0)
            {
                verticalInput *= 3;
            }
            // 수직 입력을 이용하여 캐릭터를 이동시키기
            transform.Translate(Vector3.up * verticalInput * 20.0f * Time.deltaTime);
        }
    }

    private void Move()
    { 
        float _moveDirH = Input.GetAxisRaw("Horizontal");
        float _moveDirV = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirH;
        Vector3 _moveVertical = transform.forward * _moveDirV;

        //Vector3 _moveVec = new Vector3(_moveDirH, 0, _moveDirV).normalized * walkSpeed;

        Vector3 _moveVec = (_moveHorizontal + _moveVertical).normalized * walkSpeed;


        if (!(_moveDirH == 0 && _moveDirV == 0)  || !isBorder ) {
            myRigid.MovePosition(transform.position + _moveVec * Time.deltaTime);

            
            
            //transform.position += _moveVec * walkSpeed * Time.deltaTime;

            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(_moveVec), Time.deltaTime * rotateSpeed); 
        }
    }

    private void CameraRotation()
    {
        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _cameraRotationX = _xRotation * lookSensitivity;


        currentCameraRotationX -= _cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }


    private void CharacterRotation()  // 좌우 캐릭터 회전
    {
        float _yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY)); // 쿼터니언 * 쿼터니언
        // Debug.Log(myRigid.rotation);  // 쿼터니언
        // Debug.Log(myRigid.rotation.eulerAngles); // 벡터

    }

    private void Jump()
    {
        jDown = Input.GetButtonDown("Jump");

        if (jDown && !isJump)
        {
            myRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            UnityEngine.Debug.Log("OK");
            isJump = true;
        }
    }

    private void OnClickMouse()
    {

            Ray ray = theCamera.ScreenPointToRay(Input.mousePosition);

            UnityEngine.Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 1f);
           

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            // 맞은 위치를 목적지로 저장
            movePoint = raycastHit.point;

            if (Input.GetMouseButtonDown(0))
            {
                
                if (raycastHit.transform.name == "Enemy")
                {
                    // Enemy 스크립트에서 blink 함수 호출
                }
                else if(raycastHit.transform.name == "WiringBox")
                {
                    //WireGamePanel.SetActive(true);
                    //Cursor.lockState = CursorLockMode.None;
                }
                /*
                else if(raycastHit.transform.name == "Computer 1 b")
                {
                    GameManager.isPanel = true;
                    PuzzlePanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                */
                else if(raycastHit.transform.name == "door")
                {
                    Debug.Log("door");
                    if (isidCard)
                    {
                        intDoor1++;
                        if (intDoor1 == 2)
                        {
                            intDoor1 = 0;
                        }

                        if (intDoor1 == 1)
                        {
                            Debug.Log("door1");
                            Door1.transform.rotation = Quaternion.Euler(-90.0f, 180.0f, 0);
                        }
                        else if (intDoor1 == 0)
                        {
                            Debug.Log("door2");
                            Door1.transform.rotation = Quaternion.Euler(-90.0f, 180.0f, 90.0f);
                        }
                    }
                    
                }
                else if (raycastHit.transform.name == "doorL")
                {
                    intDoor2++;
                    if (intDoor2 == 2)
                    {
                        intDoor2 = 0;
                    }

                    if (intDoor2 == 1)
                    {
                        Door2.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0);
                    }
                    else if (intDoor2 == 0)
                    {
                        Door2.transform.rotation = Quaternion.Euler(0, 270.0f, 0);
                    }
                }
                else if (raycastHit.transform.name == "doorR")
                {
                    intDoor3++;
                    if (intDoor3 == 2)
                    {
                        intDoor3 = 0;
                    }

                    if (intDoor3 == 1)
                    {
                        Door3.transform.rotation = Quaternion.Euler(0, 180.0f, 0);
                    }
                    else if (intDoor3 == 0)
                    {
                        Door3.transform.rotation = Quaternion.Euler(0, 90.0f,0);
                    }
                }
                else if(raycastHit.transform.name == "Lubricant")
                {
                    // 인벤토리에 들어감
                    isLub = true;
                    GameManager.isPanel = true;
                    lubricant.SetActive(false);
                    GetItemPanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "Cabinet")
                {
                    intCabinet++;
                    Debug.Log(intCabinet);

                    if(intCabinet == 2)
                    {
                        GameManager.isPanel = true;
                        FileDummyPanel.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                        //intCabinet = 0;
                    }
                    

                    if (intCabinet == 1) { 
                    Cabinet.transform.position = new Vector3(9.21f, 26.12f, 17.0f);
                    }
                    else if(intCabinet == 0)
                    {
                        Cabinet.transform.position = new Vector3(9.21f, 26.12f, 8.0f);
                    }
                }
                else if(raycastHit.transform.name == "battery")
                {
                    //배터리
                    //인벤토리에 들어감
                    isBattery = true;
                    GameManager.isPanel = true;
                    Battery.SetActive(false);
                    Cursor.lockState = CursorLockMode.None;
                    GetItemPanel.SetActive(true);
 
                    Debug.Log("battery");
                }
                else if(raycastHit.transform.name == "PhoneLOW")
                {
                    GameManager.isPanel = true;
                    TelephonePanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "computer 1 b")
                {
                    if (isBattery)
                    {
                        GameManager.isPanel = true;
                        JigSawGamePanel.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                    }
                }
                else if(raycastHit.transform.name == "paper1")
                {
                    GameManager.isPanel = true;
                    Paper1Panel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "paper2")
                {
                    GameManager.isPanel = true;
                    Paper2Panel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "paper3")
                {
                    GameManager.isPanel = true;
                    Paper3Panel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "paper1 (1)" || 
                    raycastHit.transform.name == "paper1 (2)" ||
                    raycastHit.transform.name == "paper1 (3)" ||
                    raycastHit.transform.name == "paper1 (4)" ||
                    raycastHit.transform.name == "paper1 (5)")
                {
                    Debug.Log("##");
                    // 전화번호 기입되어 있음
                    GameManager.isPanel = true;
                    FileDummyPanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if (raycastHit.transform.name == "idCard")
                {
                    Debug.Log("BB");
                    isidCard = true;
                    idCard.SetActive(false);
                    GetItemPanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    // 인벤토리행
                }
                else if (raycastHit.transform.name == "ControlPanel") 
                {
                    if(isidCard)
                    {
                        // 로봇 끄기
                        UnityEngine.Debug.Log("Robot");
                        Destroy(Robot);
                    }
                }
                else if(raycastHit.transform.name == "briefmarkenautomat_0001")
                {
                    // 배선 수리 미니게임                    
                    if (isLub) {
                        GameManager.isPanel = true;
                        WireGamePanel.SetActive(true);
                        Cursor.lockState = CursorLockMode.None;
                    }
                }
                else if(raycastHit.transform.name == "briefkasten_0001")
                {
                    //발전실 
                    //파티클 효과 , 필름 획득 패널 
                }
                else if(raycastHit.transform.name == "wallopen")
                {
                    if (hasKey1)
                    {
                        upWallOpenbool = true;
                    }
                }
                else if(raycastHit.transform.name == "Key_Simple_01")
                {
                    hasKey1 = true;
                    GameManager.isPanel = true;
                    Key1.SetActive(false);
                    GetItemPanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                else if(raycastHit.transform.name == "fanOnM")
                {
                    if (istape) {
                        Debug.Log("fanOn");
                        Fan.fanOn = true;
                        panPanel2.SetActive(true);

                        Cursor.lockState = CursorLockMode.None;
                    }


      

                }
                else if(raycastHit.transform.name == "tape")
                {
                    istape = true;
                    GameManager.isPanel = true;
                    tape.SetActive(false);
                    GetItemPanel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
            }
        }
    }


    void upWallOpen()
    {

            Door4.transform.position += Vector3.up * 0.1f;

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = false;
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))  // 사다리에 접촉했을 때
        {
            UnityEngine.Debug.Log("Enger Ladder");
            isClimbing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladder"))  // 사다리에서 벗어났을 때
        {
            UnityEngine.Debug.Log("Exit Ladder");
            isClimbing = false;
        }
    }
}
