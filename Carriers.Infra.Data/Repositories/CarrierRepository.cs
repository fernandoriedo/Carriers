
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces;
using Carriers.Domain.Interfaces.Repositories;

namespace Carriers.Infra.Data.Repositories
{
    public class CarrierRepository : RepositoryBase<Carrier>, ICarrierRepository
    {
        //Repositorios para buscas além do CRUD
    }
}
