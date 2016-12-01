using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class Points : MonoBehaviour {
//	Dictionary<string,Dictionary<string, int> > brukerPoeng;
//    Text txt;
//
//	void Start () 
//	{
//		SetScore ("em45el","points", 3);
//		SetScore ("emi45l","points", 4);
//		SetScore ("ertl","points", 4);
//		SetScore ("emtr","points", 5);
//		Debug.Log (GetScore ("emiel","Faen"));
//	//	Debug.Log (GetScore ("emiel","dritt"));
////		txt = gameObject.GetComponent<Text>();
////		txt.text = "Score : " + score;
////		score = 0;
//	}
//	int changeCounter = 0;
//	public int GetChangeCounteer()
//	{
//		return changeCounter;
//	}
//	public string[] Getplayernames()
//	{
//		init ();
//		return	brukerPoeng.Keys.ToArray();
//	}
//	public string[] Getplayernames(string sortingScoreType)
//	{
//		init ();
//		string[] navn = brukerPoeng.Keys.ToArray ();
//		return	navn.OrderBy (n => GetScore(n,sortingScoreType));
//	}
//		
//	void init ()
//	{
//		if(brukerPoeng != null)
//		{
//			return;
//		}
//		brukerPoeng = new Dictionary<string, Dictionary<string, int > > ();
//
//	}
//
//	public int GetScore(string brukernavn,string scoretype)
//	{
//		init ();
//		changeCounter++;
//		if(brukerPoeng.ContainsKey(brukernavn) == false)
//		{
//			print ("ingen brukernavn");
//			return 0;
//		}
//		if(brukerPoeng.ContainsKey(scoretype) == false)
//		{
//			print ("ingen scoreytype");
//			return 0;
//		}
//		return brukerPoeng [brukernavn] [scoretype];
//	}
//
//	public void SetScore(string brukernavn, string scoretype,int value)
//	{
//		init ();
//		if(brukerPoeng.ContainsKey(brukernavn) == false)
//		{
//			print("førsteinput brukernavn");
//			brukerPoeng[brukernavn] = new Dictionary<string,int>();
//		}
//		if(brukerPoeng.ContainsKey(scoretype) == false)
//		{
//			print ("førsteinput scoretype");
//			brukerPoeng[scoretype] = new Dictionary<string,int>();
//
//		}
//		brukerPoeng [brukernavn] [scoretype] = value;
//					
//	}
//
//	public void ChangeScore(string brukernavn,string scoretype, int amount)
//	{
//		init ();
//		int currscore = GetScore(brukernavn,scoretype);
//		SetScore(brukernavn,scoretype, currscore + amount);
//
//		
//	}
//	public void dritt()
//	{
//		ChangeScore ("emiel", "poeng", 1);
//	}

}
