using System;
using System.Net;

namespace HTML {
	public class HTML_DOWNLOADER {
		public HTML_DOWNLOADER(string URL, string FileName) {
			WebClient client = new WebClient();
			client.DownloadFile(URL, FileName);
			
		}
	}
}