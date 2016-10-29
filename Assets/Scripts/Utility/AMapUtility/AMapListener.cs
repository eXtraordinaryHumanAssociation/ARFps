using UnityEngine;
using System.Collections;

public class AMapListener : AndroidJavaProxy {

	public AMapListener()
		:base("com.amap.api.location.AMapLocationListener")
	{
		
	}
	void onLocationChanged (AndroidJavaObject amapLocation)  
	{  
		if (locationChanged != null) {  
			locationChanged (amapLocation);  
		}  
	}  

	public delegate void DelegateOnLocationChanged(AndroidJavaObject amap);  
	public event DelegateOnLocationChanged locationChanged;
}
