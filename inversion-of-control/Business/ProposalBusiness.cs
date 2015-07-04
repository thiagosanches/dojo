using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProposalBusiness : Business.IProposalBusiness
    {

                private ICarRepository _carRepository;

                public ProposalBusiness(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Save(Proposal obj)
        {
            try
            {
                CarRepository carRepository = new CarRepository();
                carRepository.Save(obj.Car);

                InsuredRepository insuredRepository = new InsuredRepository();
                insuredRepository.Save(obj.Insured);

                //Do some calc here...
                obj.Value = decimal.MaxValue;

                ProposalRepository proposalRepository = new ProposalRepository();
                proposalRepository.Save(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}