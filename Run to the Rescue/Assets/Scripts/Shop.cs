
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    private GameObject player;
    public Image icon1;
    public Image icon2;
    public Image icon3;
    private int index1;
    private int index2;
    private int index3;
    public int Size;
    public bool merchantOn;

    private AudioManager aud;
    public GameObject[] items;
    private Item item1;
    private Item item2;
    private Item item3;
    private bool slot1;
    private bool slot2;
    private bool slot3;
    // Start is called before the first frame update
    void Start()
    {
        slot1 = true;
        slot2 = true;
        slot3 = true;
        GameObject temp = GameObject.Find("Audio Manager");
        aud = (AudioManager)temp.GetComponent(typeof(AudioManager));
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (merchantOn)
        {
            //purchase item 1
            if (slot1)
                if (Input.GetKeyUp(KeyCode.Alpha1))
                {
                    aud.Play("merchantPurchase");
                    GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
                    InventoryUI inventoryUI = canvas.GetComponent<InventoryUI>();
                    icon1.sprite = null;
                    slot1 = false;
                }
            //purchase item 2
            if (slot2)
                if (Input.GetKeyUp(KeyCode.Alpha2))
                {
                    aud.Play("merchantPurchase");
                    GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
                    InventoryUI inventoryUI = canvas.GetComponent<InventoryUI>();

                    icon2.sprite = null;
                    slot2 = false;
                }
            //purchase item 3
            if (slot3)
                if (Input.GetKeyUp(KeyCode.Alpha3))
                {
                    aud.Play("merchantPurchase");
                    GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
                    InventoryUI inventoryUI = canvas.GetComponent<InventoryUI>();
                    icon3.sprite = null;
                    slot3 = false;
                }
        }

    }

    private class Item
    {
    }
}
