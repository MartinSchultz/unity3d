using System;
using System.Text;
using System.Security.Cryptography;

public class CryptographyHelper {
 
	public static string Md5Sum(string strToEncrypt) {
		UTF8Encoding encoding = new UTF8Encoding();
		byte[] bytes = encoding.GetBytes(strToEncrypt);
	 
		// encrypt bytes
		MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
		byte[] hashBytes = md5.ComputeHash(bytes);
	 
		// Convert the encrypted bytes back to a string (base 16)
		string hashString = "";	 
		for (int i = 0; i < hashBytes.Length; i++) {
			hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, "0"[0]);
		}
	 
		return hashString.PadLeft(32, "0"[0]);
	}

	public static string Sha1Sum(string strToEncrypt)
	{
		UTF8Encoding ue = new UTF8Encoding();
		byte[] bytes = ue.GetBytes(strToEncrypt);
		
		// encrypt bytes
		SHA1 sha = new SHA1CryptoServiceProvider();
		byte[] hashBytes = sha.ComputeHash(bytes);
		
		// Convert the encrypted bytes back to a string (base 16)
		string hashString = "";
		
		for (int i = 0; i < hashBytes.Length; i++)
		{
			hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
		}
		
		return hashString.PadLeft(32, '0');
	}
}