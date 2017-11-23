using System;

namespace PlaybackManager
{
	public static class Toolkit
	{
		public static void Log(string txt){

			Console.WriteLine (txt);
		}
		public static void Log(string txt, bool toFile){

			Console.WriteLine (txt);
		}
		public static void ShowCurrentStatus(PlaybackManager mgr){

		}
		public static void LoadLocationConfiguration(string filePath){
			
		}
	}
}

