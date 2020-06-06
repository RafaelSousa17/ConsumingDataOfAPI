using System;
using System.Net;

class MainClass 
{
	public static void Main (string[] args) 
  	{
		WebClient client = new WebClient();
		string dataJson = client.DownloadString("https://viacep.com.br/ws/01001000/json/");
		
  	}
}