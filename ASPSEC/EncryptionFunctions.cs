namespace ASPSEC
{
	public static class EncryptionFunctions
	{
		private static readonly string charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		public static string Encrypt(string input, int key)
		{
			string encrypted = string.Empty;

			foreach (char c in input)
			{
				if (charset.Contains(c))
				{
					int index = charset.IndexOf(c); 
					int newIndex = (index + key) % charset.Length;
					encrypted += charset[newIndex]; 
				}
				else
				{
					encrypted += c;
				}
			}

			return encrypted;
		}

		public static string Decrypt(string encryptedText, int key)
		{
			string decrypted = string.Empty;

			foreach (char c in encryptedText)
			{
				if (charset.Contains(c))
				{
					int index = charset.IndexOf(c);
					int newIndex = (index - key + charset.Length) % charset.Length;
					decrypted += charset[newIndex];
				}
				else
				{
					decrypted += c;
				}
			}

			return decrypted;
		}
	}

}
