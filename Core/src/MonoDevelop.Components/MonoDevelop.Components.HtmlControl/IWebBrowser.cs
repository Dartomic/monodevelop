using System;
using System.Runtime.InteropServices;

namespace MonoDevelop.Components.HtmlControl
{
	[Guid(@"eab22ac1-30c1-11cf-a7eb-0000c05bae0b")]
	public interface IWebBrowser
	{
		void GoBack();
		
		void GoForward();
		
		void GoHome();
		
		void Navigate(string Url, ref object Flags, ref object targetFrame, ref object postData, ref object headers);
		
		void Refresh();
		
		void Stop();
	}
}
