﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {
	private MarketData bitcoinData = null;

	public MarketData BitcoinData
	{
		get{
			if (bitcoinData == null) {
				bitcoinData = new MarketData ("bitcoin", "BTC", 3000, generatePriceData (3000, 100, 50));
			}
			return bitcoinData;
			
		}
		set{
			bitcoinData = value;
		}
	}

	float[] generatePriceData(int size, float startingprice, float maxVariance){
		float[] data = new float[size];
		float curr = startingprice;
		//generate random prices not sure how this will look.
		for (int i = 0; i<size; i++){
			data[i] = curr;
			curr = curr + Random.Range (-maxVariance, maxVariance);
		}
		return data;
	}

	// Use this for initialization
	void Start () {
		
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
