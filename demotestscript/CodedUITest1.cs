using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace demotestscript
{
	/// <summary>
	/// Summary description for CodedUITest1
	/// </summary>
	[CodedUITest]
	public class InvalidLoginTest1
	{
		public InvalidLoginTest1()
		{
		}

		[TestMethod]
		public void InvalidLoginTestMethod1()
		{
			// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
			int syncTime = 20000;
			this.UIMap.Open_Browser_And_Navigate();
			this.UIMap.UITheMirrorSperidianEmWindow.UITheMirrorSperidianEmDocument.WaitForControlReady(syncTime);
			try
			{
				if (this.UIMap.UITheMirrorSperidianEmWindow.UITheMirrorSperidianEmDocument.UITxtLoginNameEdit.WaitForControlExist(syncTime))
				{
					this.UIMap.Enter_Username();
					Console.WriteLine("Entered Username");
					Playback.Wait(1000);
					this.UIMap.Enter_Password();
					Console.WriteLine("Entered Password");
					Playback.Wait(1000);
					this.UIMap.Click_On_Login_Button();
					Console.WriteLine("Clicked on Login button");
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Username field is not displayed");
				throw;
			}

			try
			{
				if (this.UIMap.UITheMirrorSperidianEmWindow.UITheMirrorSperidianEmDocument.UIInvalidLoginPane.WaitForControlExist(syncTime))
				{

					Playback.Wait(5000);
					this.UIMap.Verify_Invalid_Login_Text();
					Console.WriteLine("Verify Whether Invalid Login is displayed or not");
				}
			}
			catch (Exception)
			{

				throw;
			}
			
		}

		#region Additional test attributes

		// You can use the following additional attributes as you write your tests:

		////Use TestInitialize to run code before running each test 
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{        
		//    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
		//}

		////Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{        
		//    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
		//}

		#endregion

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}
		private TestContext testContextInstance;

		public UIMap UIMap
		{
			get
			{
				if (this.map == null)
				{
					this.map = new UIMap();
				}

				return this.map;
			}
		}

		private UIMap map;
	}
}
