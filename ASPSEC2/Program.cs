using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
namespace ASPSEC2;

class Program
{
	private static string connectionString = "Server=.;Database=PersoonData;Trusted_Connection=True;";

	static void Main(string[] args)
	{
		Console.WriteLine("Voer voornaam in:");
		string voornaam = Console.ReadLine();

		Console.WriteLine("Voer achternaam in:");
		string achternaam = Console.ReadLine();

		Console.WriteLine("Voer straat in:");
		string straat = Console.ReadLine();

		Console.WriteLine("Voer huisnummer in:");
		string huisnummer = Console.ReadLine();

		Console.WriteLine("Voer postcode in:");
		string postcode = Console.ReadLine();

		Console.WriteLine("Voer woonplaats in:");
		string woonplaats = Console.ReadLine();

		Console.WriteLine("Voer creditcardnummer in:");
		string creditcardnummer = Console.ReadLine();

		byte[] encryptedCreditCardNumber = EncryptCreditCardNumber(creditcardnummer);

		SavePersonData(voornaam, achternaam, straat, huisnummer, postcode, woonplaats, encryptedCreditCardNumber);
	}

	static byte[] EncryptCreditCardNumber(string creditcardnummer)
	{
		using (Aes aesAlg = Aes.Create())
		{
			aesAlg.Key = Encoding.UTF8.GetBytes("0123456789abcdef");
			aesAlg.IV = Encoding.UTF8.GetBytes("abcdef9876543210");

			ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

			using (MemoryStream msEncrypt = new MemoryStream())
			{
				using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
				using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
				{
					swEncrypt.Write(creditcardnummer);
				}
				return msEncrypt.ToArray();
			}
		}
	}

	static void SavePersonData(string voornaam, string achternaam, string straat, string huisnummer, string postcode, string woonplaats, byte[] encryptedCreditCardNumber)
	{
		string query = "INSERT INTO Persoon (Voornaam, Achternaam, Straat, Huisnummer, Postcode, Woonplaats, Creditcardnummer) " +
					   "VALUES (@Voornaam, @Achternaam, @Straat, @Huisnummer, @Postcode, @Woonplaats, @Creditcardnummer)";

		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@Voornaam", voornaam);
			command.Parameters.AddWithValue("@Achternaam", achternaam);
			command.Parameters.AddWithValue("@Straat", straat);
			command.Parameters.AddWithValue("@Huisnummer", huisnummer);
			command.Parameters.AddWithValue("@Postcode", postcode);
			command.Parameters.AddWithValue("@Woonplaats", woonplaats);
			command.Parameters.AddWithValue("@Creditcardnummer", encryptedCreditCardNumber);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		Console.WriteLine("Gegevens zijn succesvol opgeslagen in de database!");
	}
}
