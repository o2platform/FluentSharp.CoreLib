﻿using FluentSharp.NUnit;
using NUnit.Framework;

namespace FluentSharp.CoreLib.Test
{
    [TestFixture]
    public class Test_IO_ExtensionMethods_FileInfo : NUnitTests
    {
        [Test] public void extension()
        {
            var fileName  = "aaa";
            var extension = "txt";
            var testFile  = "{0}.{1}".format(fileName, extension) ;

            testFile.extension().assert_Equals    (".txt");
            testFile.extension().assert_Not_Equals(".abc");

            testFile.extension(".txt").assert_True ();
            testFile.extension("txt" ).assert_True ();
            testFile.extension(".abc").assert_False();
        }
    }
}
