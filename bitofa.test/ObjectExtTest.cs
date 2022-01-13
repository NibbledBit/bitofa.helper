using BitOfA.Helper.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitOfA.test {
    [TestClass]
    public class ObjectExtTest {
        [TestMethod]
        public void Test_Exists_True() {
            object test = new { Test = "Not Null" };
            var exists = test.Exists();

            test.Should().NotBeNull();
            exists.Should().BeTrue();
        }
        [TestMethod]
        public void Test_Exists_False() {
            object test = null;
            var exists = test.Exists();

            test.Should().BeNull();
            exists.Should().BeFalse();
        }
        [TestMethod]
        public void Test_DoesNotExist_True() {
            object test = null;
            var exists = test.DoesNotExist();

            test.Should().BeNull();
            exists.Should().BeTrue();
        }
        [TestMethod]
        public void Test_DoesNotExist_False() {
            object test = new { Test = "Not Null" };
            var exists = test.DoesNotExist();

            test.Should().NotBeNull();
            exists.Should().BeFalse();
        }
    }
}
