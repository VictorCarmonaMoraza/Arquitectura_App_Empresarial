using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        #region Metodos_Sicronos
        /// <summary>
        /// Inserta un nuevo cliente.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        bool Insert(Customers customers);

        /// <summary>
        /// Actualiza los datos del cliente.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        bool Update(Customers customers);

        /// <summary>
        /// Elimina el cliente por su Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        bool Delete(string customerId);

        /// <summary>
        /// Busqueda de cliente por Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Customers GetCustomer(string customerId);

        /// <summary>
        /// Devolver todos los clientes
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customers> GetAll();

        #endregion Metodos_Sicronos

        #region Metodos_Asincronos

        Task<bool> InsertAsync(Customers customers);

        Task<bool> UpdateAsync(Customers customers);

        Task<bool> DeleteAsync(string customerId);

        Task<Customers> GetCustomersAsync(string customerId);

        Task<IEnumerable<Customers>> GetAllAsync();

        #endregion Metodos_Asincronos
    }
}
