
using UnityEngine;
using DG.Tweening;

public class vqmm : MonoBehaviour
{
    public float duration;
    public int spice;
    public int rounds;
    public Transform vq;
    public bool isPlaying;
    public float deg;
    public int index_item_reward;

    // Start is called before the first frame update
    private void Awake()
    {
        // Lấy dữ liệu khởi tạo vòng quay
    }
    void Start()
    {
        deg = 360 / spice;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
        {
            spin();
        }
    }   

    public void play()
    {
        isPlaying = false;
        vq.eulerAngles = Vector3.zero;
    }

    public void spin()
    {
        if (!isPlaying)
        {
            var angle = 360 * rounds + Mathf.FloorToInt(Random.Range(0,deg)) + deg*index_item_reward;
            isPlaying = true;
            vq.DOLocalRotate(new Vector3(0, 0, angle), duration, RotateMode.FastBeyond360).SetRelative(true).SetEase(Ease.Linear);
        }
    }

    private void getLucky()
    {

    }
}
