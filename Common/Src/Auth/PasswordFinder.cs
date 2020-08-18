/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Security;
using System.Runtime.InteropServices;
using Org.BouncyCastle.OpenSsl;

namespace Oci.Common.Auth
{
    /// <summary>An implementation to save and retrieves passphrase.</summary>
    public class PasswordFinder : IPasswordFinder
    {
        private readonly SecureString passPhrase;

        public PasswordFinder(SecureString passPhrase)
        {
            this.passPhrase = passPhrase;
        }

        public char[] GetPassword()
        {
            var length = passPhrase.Length;
            char[] passPhraseChars = new char[length];
            var valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(passPhrase);
                Marshal.Copy(valuePtr, passPhraseChars, 0, length);
                return passPhraseChars;
            }
            finally
            {
                if (valuePtr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
                }
            }
        }
    }
}
