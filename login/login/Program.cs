﻿/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 4/15/2024
 * Time: 4:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
