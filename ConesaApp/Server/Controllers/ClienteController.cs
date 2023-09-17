using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConesaApp.Database.Data.Entities;
using ConesaApp.Database.Data;


namespace ConesaApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;
        public ClienteController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            if (_dbContext.Clientes == null)
            {
                return NotFound();
            }
            return await _dbContext.Clientes.ToListAsync(); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteId(int id)
        {
            if (_dbContext.Clientes == null)
            {
                return NotFound();
            }
            var cliente = await _dbContext.Clientes.Where(x => x.clienteID == id).FirstOrDefaultAsync();
            if (cliente == null)
            {
                return NotFound($"No existe un cliente de ID= {id}");
            }

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostCliente(Cliente cliente)
        {
            try
            {
                _dbContext.Clientes.Add(cliente);
                await _dbContext.SaveChangesAsync();
                //Aca nos devuelve el cliente recién creado
                return cliente.clienteID;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> PutCliente(int id, Cliente cliente)
        {
            //if (id != cliente.clienteID)
            //{
            //    return BadRequest();
            //}
            //_dbContext.Clientes.Entry(cliente).State = EntityState.Modified;
            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{

            //    throw;
            //}
            //return Ok($"Se ha modificado el cliente {cliente.nombre} {cliente.apellido}");
            var clienteSolicitado = _dbContext.Clientes
               .Where(e => e.clienteID == id).FirstOrDefault();

            if (clienteSolicitado == null)
            {
                return NotFound("No se encontró el cliente a modificar");
            }

            clienteSolicitado.telefono = cliente.telefono;
            clienteSolicitado.mail = cliente.mail;
            clienteSolicitado.nombre = cliente.nombre;
            clienteSolicitado.apellido = cliente.apellido;
            clienteSolicitado.ciudad = cliente.ciudad;
            clienteSolicitado.direccion = cliente.direccion;

            try
            {
                _dbContext.Clientes.Update(clienteSolicitado);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Los datos no se han podido actualizar");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteCliente(int id)
        {
            var cliente = _dbContext.Clientes.Where(x => x.clienteID == id).FirstOrDefault();
            if (cliente == null)
            {
                return NotFound($"No se encontró el cliente de Id {id}");
            }
            try
            {
                _dbContext.Clientes.Remove(cliente);
                await _dbContext.SaveChangesAsync();
                return Ok($"El registro de {cliente.nombre} {cliente.apellido} se ha eliminado correctamente");
            }
            catch (Exception e)
            {

                return BadRequest($"Los datos no pudieron ser eliminados por: {e.Message}");
            }
        }
    }
}
