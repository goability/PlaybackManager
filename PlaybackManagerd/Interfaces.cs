using System;
using PlaybackManager.Enumeration;

namespace PlaybackManager.Interfaces
{
	public interface IShow{ void Show();};
	public interface ICameraDiscovery { 
	    Enumeration.CameraStatus GetStatus();
		string GetCameraIdentifier();
	};
	public interface ICameraConfigurable{
		void LoadConfiguration (string fileName);
	};
}

