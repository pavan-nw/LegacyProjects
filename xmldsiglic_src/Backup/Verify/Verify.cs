using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace CodeProject.XmlDSigLic
{
	/// <summary>
	/// Console application to verify a signed XML file.
	/// </summary>
	class Verify
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			// Verify that an XML document path is provided.
			if (args.Length != 1 || !File.Exists(args[0]))
			{
				Console.Error.WriteLine("You must provide the path to an XML " +
					"document to verify.");
				return 1;
			}

			// Get the XML content from the embedded XML public key.
			Stream s = null;
			string xmlkey = string.Empty;
			try
			{
				s = typeof(Verify).Assembly.GetManifestResourceStream(
					"CodeProject.XmlDSigLic.PubKey.xml");

				// Read-in the XML content.
				StreamReader reader = new StreamReader(s);
				xmlkey = reader.ReadToEnd();
				reader.Close();
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("Error: could not import public key: {0}",
					e.Message);
				return 1;
			}

			// Create an RSA crypto service provider from the embedded
			// XML document resource (the public key).
			RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
			csp.FromXmlString(xmlkey);

			// Load the signed XML license file.
			XmlDocument xmldoc = new XmlDocument();
			xmldoc.Load(args[0]);

			// Create the signed XML object.
			SignedXml sxml = new SignedXml(xmldoc);

			try
			{
				// Get the XML Signature node and load it into the signed XML object.
				XmlNode dsig = xmldoc.GetElementsByTagName("Signature",
					SignedXml.XmlDsigNamespaceUrl)[0];
				sxml.LoadXml((XmlElement)dsig);
			}
			catch
			{
				Console.Error.WriteLine("Error: no signature found.");
				return 1;
			}

			// Verify the signature.
			if (sxml.CheckSignature(csp))
				Console.WriteLine("SUCCESS: Signature valid.");
			else
				Console.WriteLine("FAILED: Signature invalid.");

			return 0;
		}
	}
}
