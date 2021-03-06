﻿using UnityEngine;

namespace com.holisticda.tardisx
{
	public class IntGameEventListener : MonoBehaviour
	{
		//---------------------------------------------------------------------
		// Editor
		//---------------------------------------------------------------------
		
		public IntGameEvent Event;
		public IntUnityEvent Response;

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

		public void OnEventRaised(int param)
		{
			Response.Invoke(param);
		}
	}
}
