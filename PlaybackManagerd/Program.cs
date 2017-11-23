using System;
using System.Text;
using PlaybackManager.Enumeration;
using PlaybackManager.Interfaces;
namespace PlaybackManager
{
	class PlaybackManagerd
	{
		/*
		 *  Playback Manager Daemon
		 *  
		 *  Create one or more PlaybackManagers that will:
		 * 
		 * 		Wait for HTTP connection requests like:
		 * 
		 * 	1.) Start or Stop an entire Playback Manager service
		 *  2.) Start or Stop any camera
		 *  3.) Pause any camera
		 *  4.) Show last 20 images for all cameras
		 *  5.) Provide a set of images based on an input range
		 *  6.) Show Active Cameras with Locations and FileCount
		 *  7.) Show
		 *  
		*/
		public static void Main (string[] args)
		{
			Toolkit.Log("Playback Manager Engine running.", false);

			StringBuilder sb = null;


			//Setup TCP Listener for command requests

			//OnCallback: Log entry

			//System


		}
	}

}
