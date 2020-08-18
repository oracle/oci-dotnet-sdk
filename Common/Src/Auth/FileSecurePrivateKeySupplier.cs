/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.IO;
using System.Security;
using Oci.Common.Utils;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A file-based key provider with additional security checks. Before reading private key from a pem key file,
    /// this class checks the following:
    /// the key file to be encrypted (protected by pass phrase),
    /// the key file has minimum key length of 2048, and
    /// the encryption mode is CBC.
    /// </summary>
    public class FileSecurePrivateKeySupplier : FilePrivateKeySupplier
    {
        public FileSecurePrivateKeySupplier(string pemFilePath, SecureString passPhrase) : base(pemFilePath, passPhrase)
        {
            try
            {
                // private key should be encrypted
                Org.BouncyCastle.Utilities.IO.Pem.PemObject keyPair;
                StreamReader reader = File.OpenText(FileUtils.ExpandUserHome(pemFilePath));
                keyPair = new PemReader(reader, new PasswordFinder(passPhrase)).ReadPemObject();
                var headers = keyPair.Headers.GetEnumerator();
                Dictionary<string, string> headerDict = new Dictionary<string, string>();
                while (headers.MoveNext())
                {
                    var header = (Org.BouncyCastle.Utilities.IO.Pem.PemHeader)headers.Current;
                    headerDict.Add(header.Name, header.Value);
                }
                if (!headerDict.ContainsKey("Proc-Type") || !headerDict["Proc-Type"].Equals("4,ENCRYPTED"))
                {
                    throw new InvalidDataException("private key must be encrypted with a passphrase");
                }

                // only CBC chaining mode is supported
                if (headerDict.ContainsKey("DEK-Info"))
                {
                    var headerValue = headerDict["DEK-Info"];
                    var dekInfo = headerValue.Split(',');
                    var tokens = dekInfo[0].Split('-');
                    if (!tokens[tokens.Length - 1].Equals("CBC"))
                    {
                        throw new InvalidDataException("Only CBC chaining mode is supported and it is secure");
                    }
                }

                // private key bit length should be at least 2048
                if (GetKey().Modulus.BitLength < 2048)
                {
                    throw new InvalidDataException("private key bit length should be at least 2048");
                }
            }
            catch (DataLengthException e)
            {
                throw new InvalidDataException("Invalid Key has been provided", e);
            }
        }
    }
}
