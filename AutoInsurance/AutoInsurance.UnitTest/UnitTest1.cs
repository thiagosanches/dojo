using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Business;
using AutoInsurance.Model;
using System.Collections.Generic;
using System.Linq;
namespace AutoInsurance.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteInserirCarro()
        {
            CarBusiness cBusiness = new CarBusiness();
            Car carro = new Car();
            carro.Manufacturer = "Toyota";
            carro.Model = "Corola";

            cBusiness.Save(carro);
            Assert.IsTrue(carro.Id > 0);
        }

        [TestMethod]
        public void TesteBuscarTodos()
        {
            CarBusiness business = new CarBusiness();
            List<Car> listCar = business.FindAll();
            Assert.IsTrue(listCar.Count > 0);
        }
        [TestMethod]
        public void TesteInserirSegurado()
        {
            InsuredBusiness iBusiness = new InsuredBusiness();
            Insured insured = new Insured();
            insured.FirstName = "Donizete";
            insured.LastName = "Batista Junior";
            insured.Age = 19;

            iBusiness.Save(insured);
            Assert.IsTrue(insured.Id > 0);
        }

        [TestMethod]
        public void TestFindAllInsured()
        {
            InsuredBusiness iBusiness = new InsuredBusiness();
            List<Insured> listInsured = iBusiness.FindAll();
            Assert.IsTrue(listInsured.Count > 0);
        }
        [TestMethod]
        public void TestInserirProposta()
        {
            ProposalBusiness pBusiness = new ProposalBusiness();
            Proposal proposal = new Proposal();

            CarBusiness carBusiness = new CarBusiness();
            proposal.Car = carBusiness.FindAll().First();

            InsuredBusiness iBusiness = new InsuredBusiness();
            proposal.Insured = iBusiness.FindAll().First();
            proposal.Value = (int)pBusiness.Calculate(proposal);
            pBusiness.Save(proposal);
            Assert.IsTrue(proposal.Id > 0);          
        }

        [TestMethod]
        public void TestAllProposal()
        {
            ProposalBusiness pBusiness = new ProposalBusiness();
            List<Proposal> listProposal = pBusiness.FindAll();
            Assert.IsTrue(listProposal.Count > 0);
        }
    }
}
