using System;

namespace PlaybackManager.Enumeration
{
	public enum FileStatus{
		FILE_CORRUPT = 0,
		FILE_MISSING = 1
	};
	public enum ConfigurationStatus{
		FILE_CORRUPT = 0,
		FILE_MISSING = 1
	}
	public enum CameraStatus{
		OFF = 0,
		ON =1,
		ON_DISABLED=2,
		ON_ENABLED=3
	}
}

