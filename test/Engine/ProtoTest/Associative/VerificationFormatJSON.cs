using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using ProtoCore.AST.AssociativeAST;
using ProtoCore.DSASM.Mirror;
using ProtoCore.Lang;
using ProtoTest.TD;
using ProtoTestFx.TD;
namespace ProtoTest.Associative
{
    class VerificationFormatJSON : ProtoTestBase
    {
        [Test]
        public void TestAssignment01()
        {

            String code = 
            string verification =
@" 
    {""a"": 1}
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestAssignment02()
        {
            string code =
@"
            string verification =
@" 
    {
        ""a"": 1,
        ""b"": 2
    }
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestNullAssignment01()
        {
            string code =
@"
            string verification =
@" 
    {
        ""a"": null,
    }
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestNullAssignment02()
        {
            string code =
@"
            string verification =
@" 
    {
        ""a"": null,
        ""b"": null,
    }
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestFunctionCall01()
        {
            string code =
@"
            string verification =
@" 
    {""x"": 1}
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestDouble01()
        {
            string code =
@"
            string verification =
@" 
    {""a"": 1.0}
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestDouble02()
        {
            string code =
@"
            string verification =
@" 
    {
    }
";
            thisTest.RunAndVerify(code, verification);

        }

        [Test]
        public void TestDouble03()
        {
            string code =
@"
            string verification =
@" 
    {
    }
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestArrayAssignment01()
        {
            string code =
@"
            string verification =
@" 
    {""a"": [1,2,3]}
";
            thisTest.RunAndVerify(code, verification);
        }

        [Test]
        public void TestArrayAssignment02()
        {
            string code =
@"
            string verification =
@" 
{
    ""i"": 2,
    ""a"": [1,2,5]
}
";
            thisTest.RunAndVerify(code, verification);
        }
      
        [Test]
        public void TestNestedArrayAssignment01()
        {
            string code =
@"
            string verification =
@" 
{
    ""a"": [1,2,[3,4]]
}
";
            thisTest.RunAndVerify(code, verification);
        }

    }
}