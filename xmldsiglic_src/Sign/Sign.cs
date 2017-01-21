using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace CodeProject.XmlDSigLic
{
	/// <summary>
	/// Console application to sign an XML file.
	/// </summary>
	class Sign
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
				Console.Error.WriteLine("Error: You must provide the path to an XML " +
					"document to sign.");
				return 1;
			}

			// Load the license request file.
			XmlDocument xmldoc = new XmlDocument();
			xmldoc.Load(args[0]);

			// Get the key pair from the key store.
			CspParameters parms = new CspParameters(1);			// PROV_RSA_FULL
			parms.Flags = CspProviderFlags.UseMachineKeyStore;	// Use Machine store
			parms.KeyContainerName = "CodeProject";				// "CodeProject" container
			parms.KeyNumber = 2;								// AT_SIGNATURE
			RSACryptoServiceProvider csp = new RSACryptoServiceProvider(parms);

			// Creating the XML signing object.
			SignedXml sxml = new SignedXml(xmldoc);
			sxml.SigningKey = csp;

			// Set the canonicalization method for the document.
			sxml.SignedInfo.CanonicalizationMethod = 
				SignedXml.XmlDsigCanonicalizationUrl; // No comments.

			// Create an empty reference (not enveloped) for the XPath
			// transformation.
			Reference r = new Reference("");

			// Create the XPath transform and add it to the reference list.
			r.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));

			// Add the reference to the SignedXml object.
			sxml.AddReference(r);

			// Compute the signature.
			sxml.ComputeSignature();

			// Get the signature XML and add it to the document element.
			XmlElement sig = sxml.GetXml();
			xmldoc.DocumentElement.AppendChild(sig);

			// Write-out formatted signed XML to console (allow for redirection).
			XmlTextWriter writer = new XmlTextWriter(Console.Out);
			writer.Formatting = Formatting.Indented;

			try
			{
				xmldoc.WriteTo(writer);
			}
			finally
			{
				writer.Flush();
				writer.Close();
			}

			return 0;
		}
	}
}
