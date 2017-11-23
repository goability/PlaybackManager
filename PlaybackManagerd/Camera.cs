using System;
using PlaybackManager.Interfaces;

namespace PlaybackManager
{
	public class Camera : ICameraDiscovery, ICameraConfigurable{

		private CameraConfig m_Config;

		private string m_Name = null;
		private string m_uniqueID = null;
		private object lockObj = new object();
		private Enumeration.CameraStatus m_Status;

		public Camera(string name, string uniqueID){
			this.m_Name = name;
			this.m_uniqueID = uniqueID;
		}
		public Enumeration.CameraStatus GetStatus () { return m_Status; }

		public string FriendlyName { get { return this.m_Name; } }


		public void LoadConfiguration(string configFilePath){


		}

		//ICameraDiscovery
		public virtual string GetCameraIdentifier(){
			return null;
		}
	}
}

