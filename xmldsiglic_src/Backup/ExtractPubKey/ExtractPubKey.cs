using System;
using System.Security.Cryptography;

namespace CodeProject.XmlDSigLic
{
	/// <summary>
	/// Extracts the public key from the CodeProject key container and exports
	/// it to an XML file via stdout.
	/// </summary>
	class ExtractPubKey
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			CspParameters parms = new CspParameters(1);			// PROV_RSA_FULL
			parms.Flags = CspProviderFlags.UseMachineKeyStore;	// Use Machine store
			parms.KeyContainerName = "CodeProject";				// "CodeProject" container
			parms.KeyNumber = 2;								// AT_SIGNATURE

			RSACryptoServiceProvider csp = new RSACryptoServiceProvider(parms);
			Console.WriteLine(csp.ToXmlString(false));

			// Output left unformatted to reduce size of embedded resource.
		}
	}
}
