using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infraestructure.Interface;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain: ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        #region metodos_asincronos
        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customersRepository.InsertAsync(customers);
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _customersRepository.DeleteAsync(customerId);
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customersRepository.UpdateAsync(customers);
        }

        public async Task<Customers> GetCustomersAsync(string customerId)
        {
            return await _customersRepository.GetCustomersAsync(customerId);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion metodos_asincronos


        #region metodos_sincronos
        public bool Insert(Customers customers)
        {
            return _customersRepository.Insert(customers);
        }

        public bool Delete(string customerId)
        {
            return _customersRepository.Delete(customerId);
        }

        public bool Update(Customers customers)
        {
            return _customersRepository.Update(customers);
        }

        public Customers GetCustomer(string customerId)
        {
            return _customersRepository.GetCustomer(customerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customersRepository.GetAll();
        }

        #endregion metodos_sincronos
    }
}
