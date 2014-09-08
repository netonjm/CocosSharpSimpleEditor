using System;
using System.Diagnostics;
using CocosSharp;
//using Microsoft.Xna.Framework;

namespace ClassicCalculator
{

	static class Program
	{



		[STAThread]
		static void Main(string[] args)
		{

			ResourcesLoader.Instance.Args = args;

			CCApplication application = new CCApplication(false, new CCSize(1024f, 768f));
			application.ApplicationDelegate = new AppDelegate();
			application.StartGame();
		}
	}


}

