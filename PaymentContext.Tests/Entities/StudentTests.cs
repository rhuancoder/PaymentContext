using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("76147117343", EDocumentType.CPF);
            var email = new Email("batman@dc.com");
            var student = new Student(name, document, email);

            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("76147117343", EDocumentType.CPF);
            var email = new Email("batman@dc.com");
            var student = new Student(name, document, email);
            
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            Assert.Fail();
        }
    }
}
