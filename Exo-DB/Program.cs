﻿using System;
using System.Windows.Forms;

namespace EXO_DB
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (MainForm mainForm = new MainForm())
			{
				Application.Run(mainForm: mainForm);
			}
		}
	}
}
