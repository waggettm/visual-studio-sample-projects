using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessCorpAdditionImplementation;
using Data.Contracts;
using Moq;

namespace BusinessCorpAdditionImplementationTests
{
    [TestClass]
    public class BusinessRequirementsAdditionTests
    {
        [TestMethod]
        public void AddShouldReturnTheSumOfTheTwoInputs()
        {
            var sut = new BusinessRequirementsAddition(new Mock<ITransactionRepository>().Object, new Mock<IDoubleTransactionGenerator>().Object);
            Assert.AreEqual(7.7, sut.Add(4.4, 3.3));
        }

        [TestMethod]
        public void AddShouldLogTheTransactionGeneratedByTheGenerator()
        {
            var mockTransactionRepo = new Mock<ITransactionRepository>();
            var mockDoubleTransactionGenerator = new Mock<IDoubleTransactionGenerator>();

            // GIVEN: A generator which returns a transaction
            var expectedTransactionGenerated = new Mock<IDoubleTransaction>();
            mockDoubleTransactionGenerator.Setup(x => x.MakeDoubleTransaction(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>())).Returns(expectedTransactionGenerated.Object);

            IDoubleTransaction transactionGiven = null;
            mockTransactionRepo.Setup(x => x.AddTransaction(It.IsAny<IDoubleTransaction>())).Callback((IDoubleTransaction transaction) =>
            {
                transactionGiven = transaction;
            });

            // WHEN: Add is called
            var sut = new BusinessRequirementsAddition(mockTransactionRepo.Object, mockDoubleTransactionGenerator.Object);
            sut.Add(4.2, 4.2);

            // THEN: The transaction repo add method is called to log the stranaction
            Assert.AreSame(expectedTransactionGenerated.Object, transactionGiven);
        }
    }
}
