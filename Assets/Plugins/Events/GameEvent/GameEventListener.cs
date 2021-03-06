﻿using UnityEngine;
using UnityEngine.Events;

namespace com.holisticda.tardisx
{
	public class GameEventListener : MonoBehaviour
	{
		//---------------------------------------------------------------------
		// Editor
		//---------------------------------------------------------------------
		
		public GameEvent Event;
		public UnityEvent Response;

		//---------------------------------------------------------------------
		// Messages
		//---------------------------------------------------------------------
		
		private void OnEnable()
		{
			Event.RegisterListener(this);
		}

		private void OnDisable()
		{
			Event.UnRegisterListener(this);
		}

		//---------------------------------------------------------------------
		// Events
		//---------------------------------------------------------------------
		
		public void OnEventRaised()
		{
			Response.Invoke();
		}
	}
}
