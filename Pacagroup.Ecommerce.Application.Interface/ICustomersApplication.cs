using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Tranversal.Common;

namespace Pacagroup.Ecommerce.Application.Interface

{
    public interface ICustomersApplication
    {
        #region Metodos_Sicronos
        /// <summary>
        /// Inserta un nuevo cliente.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        Response<bool> Insert(CustomersDTO customers);

        /// <summary>
        /// Actualiza los datos del cliente.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        Response<bool> Update(CustomersDTO customers);

        /// <summary>
        /// Elimina el cliente por su Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Response<bool> Delete(string customerId);

        /// <summary>
        /// Busqueda de cliente por Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Response<CustomersDTO> GetCustomer(string customerId);

        /// <summary>
        /// Devolver todos los clientes
        /// </summary>
        /// <returns></returns>
        Response<IEnumerable<CustomersDTO>> GetAll();

        #endregion Metodos_Sicronos

        #region Metodos_Asincronos

        Task<Response<bool>> InsertAsync(CustomersDTO customers);

        Task<Response<bool>> UpdateAsync(CustomersDTO customers);

        Task<Response<bool>> DeleteAsync(string customerId);

        Task<Response<CustomersDTO>> GetCustomersAsync(string customerId);

        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();

        #endregion Metodos_Asincronos
    }
}
