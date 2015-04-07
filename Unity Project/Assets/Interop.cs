using UnityEngine;
using System.Collections;
using System;

public static class Interop
{
	public static event EventHandler LoadInterstitialEvent;
	public static event EventHandler ShowInterstitialEvent;
	
	public static event EventHandler OnInterstitialClosed;
	
	public static void LoadInterstitialAd()
	{
		if (LoadInterstitialEvent != null)
		{
			LoadInterstitialEvent(null, EventArgs.Empty);
		}
	}
	
	public static void ShowInterstitialAd()
	{
		if (ShowInterstitialEvent != null)
		{
			ShowInterstitialEvent(null, EventArgs.Empty);
		}
	}
	
	public static void InterstitialClose()
	{
		if (OnInterstitialClosed != null)
		{
			OnInterstitialClosed(null, EventArgs.Empty);
		}
	}
}