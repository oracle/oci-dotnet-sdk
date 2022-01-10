/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using Oci.Common;
using Xunit;

namespace Oci.ObjectstorageService.Transfer
{
    [ExcludeFromCodeCoverage]
    public class StreamChunkCreatorTests : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void StreamChunkVerification()
        {
            var inputStr = "aaaaaaaaaa";
            var sourceStream = GenerateStreamFromString(inputStr);
            var chunkCreator = new StreamChunkCreator(sourceStream, 2);

            var builder = new StringBuilder();
            var i = 0;
            foreach (var stream in chunkCreator)
            {
                builder.Append(GetStringFromStream(stream));
                i++;
            }

            Assert.True(inputStr.Equals(builder.ToString()));
            Assert.Equal(inputStr.Length / 2, i);
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static string GetStringFromStream(Stream stream)
        {
            var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

    }
}
