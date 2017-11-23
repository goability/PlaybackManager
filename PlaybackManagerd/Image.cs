using System;
using PlaybackManager.Interfaces;

namespace PlaybackManager
{
	class Image : Interfaces.IShow{
		private Enumeration.FileStatus m_Status;
		private string m_filepath = null;
		private string m_FileName = null;
		private DateTime m_FileDateTime;
		private object lockObj = new object();
		private string m_uniqueID;

		public Image(string filepath, string filename, DateTime filedt, string uniqueID){
			this.m_filepath = filepath;
			this.m_FileName = filename;
			this.m_FileDateTime = filedt;
			this.m_uniqueID = uniqueID;
			Toolkit.Log ("Image: " + m_uniqueID + " Created");
		}


		public void Show(){
			Console.WriteLine ("Showing image " + m_uniqueID);
		}

		public virtual string GetName(){
			lock (this.lockObj) {
				return this.m_FileName;			
			}
		}
	}

}

