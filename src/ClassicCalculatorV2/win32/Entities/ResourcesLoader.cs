using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassicCalculator
{
	class ResourcesLoader
	{

		public string[] Args { get; set; }


		private static ResourcesLoader _instance;

		public static ResourcesLoader Instance
		{
			get {

				if (_instance == null)
					_instance = new ResourcesLoader();

				return _instance;
			
			}
		}

		public bool HasFileToLoad { get { return Args.Length > 0; } }

		public string FirstFile { get { return Args[0]; } }


	}
}
