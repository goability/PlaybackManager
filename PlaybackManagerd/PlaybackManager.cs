using System;
using System.Collections;
using System.Collections.Generic;

namespace PlaybackManager
{
	public class PlaybackManager{
		private string m_CameraCollectionName = null;
		private string m_FriendlyName = null;
		private object lockObj = new object();
		private string m_uniqueID;

		private  System.Collections.SortedList m_Cameras = null;

		public PlaybackManager(){
			//Load Config
			Toolkit.Log("Configuration Loaded");



			//Create storage for Cameras

			Toolkit.Log ("There are " + m_Cameras.Count + " cameras active");
		

		}
		public PlaybackManager(string collName, string friendlyName, string uniqueID){
			this.m_CameraCollectionName = collName;
			this.m_FriendlyName = friendlyName;
			this.m_uniqueID = uniqueID;
		}
		public List<Camera> GetCamerasActive( ){

			List<Camera> activeCameras = null;
			foreach (Camera cam in m_Cameras){

				if (cam.GetStatus() == Enumeration.CameraStatus.ON) {
					if (activeCameras == null) {
						activeCameras = new List<Camera> ();
					}
					activeCameras.Add (cam);
				}
			}

			return activeCameras;
		}

		protected virtual void InitializeCameras(List<CameraConfig> camConfigs){

			//
		}
	}
}

