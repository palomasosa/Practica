using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConesaApp.Database.Data.Entities;
using ConesaApp.Database.Data;


namespace ConesaApp.Server.Controllers
{
    [Route("api/Vehiculos")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;
        public VehiculoController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("/Vehiculos")]
        public async Task<ActionResult<List<Vehiculo>>> GetVehiculos()
        {
            //var vehiculos = await _dbContext.Vehiculos
            //                    .ToListAsync();

            //if (vehiculos == null)
            //{
            //    return NotFound($"No hay vehículos para mostrar");

            //}

            //var cliente = await _dbContext.Clientes.ToListAsync();

            //return vehiculos;
             return await _dbContext.Vehiculos.Include(x => x.Poliza).Include(x=>x.Poliza.Cobertura).Include(y => y.Cliente).ToListAsync();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculoId(int id)
        {
            if (_dbContext.Vehiculos == null)
            {
                return NotFound();
            }
            var vehiculo = await _dbContext.Vehiculos.Where(x => x.VehiculoID == id).FirstOrDefaultAsync();
            if (vehiculo == null)
            {
                return NotFound($"No existe un vehiculo de ID= {id}");
            }

            return Ok(vehiculo);
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostVehiculo(Vehiculo vehiculo)
        {
            try
            {
                _dbContext.Vehiculos.Add(vehiculo);
                await _dbContext.SaveChangesAsync();
                //Aca nos devuelve el cliente recién creado
                return vehiculo.VehiculoID;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Vehiculo>> PutVehiculo(int id, Vehiculo vehiculo)
        {
            var vehiculoSolicitado = _dbContext.Vehiculos
               .Where(e => e.VehiculoID == id).FirstOrDefault();

            if (vehiculoSolicitado == null)
            {
                return NotFound("No se encontró el vehiculo a modificar");
            }

            vehiculoSolicitado.Patente = vehiculo.Patente;
            vehiculoSolicitado.Año = vehiculo.Año;
            vehiculoSolicitado.Marca = vehiculo.Marca;
            vehiculoSolicitado.Poliza = vehiculo.Poliza;
            vehiculoSolicitado.Cliente = vehiculo.Cliente;

            try
            {
                _dbContext.Vehiculos.Update(vehiculoSolicitado);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Los datos no se han podido actualizar");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteVehiculo(int id)
        {
            var vehiculo = _dbContext.Vehiculos.Where(x => x.VehiculoID == id).FirstOrDefault();
            if (vehiculo == null)
            {
                return NotFound($"No se encontró el vehiculo de Id {id}");
            }
            try
            {
                _dbContext.Vehiculos.Remove(vehiculo);
                await _dbContext.SaveChangesAsync();
                return Ok($"El registro de patente {vehiculo.Patente} se ha eliminado correctamente");
            }
            catch (Exception e)
            {

                return BadRequest($"Los datos no pudieron ser eliminados por: {e.Message}");
            }
        }
    }
}
