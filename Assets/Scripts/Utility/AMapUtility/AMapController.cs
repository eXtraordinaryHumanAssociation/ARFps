using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AMapController : MonoBehaviour
{
	public Text txtLocation;
	public Text txtInfo;
	public AMapListener amap;
	public AndroidJavaClass jcu;
	public AndroidJavaObject jou;
	public AndroidJavaObject mLocationClient;
	public AndroidJavaObject mLocationOption;

}

