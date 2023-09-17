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
    public class PagoController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;
        public PagoController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pagos>>> GetPagos()
        {
            if (_dbContext.Pagos == null)
            {
                return NotFound();
            }
            return await _dbContext.Pagos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pagos>> GetPagoId(int id)
        {
            if (_dbContext.Pagos == null)
            {
                return NotFound();
            }
            var pago = await _dbContext.Pagos.Where(x => x.pagoID == id).FirstOrDefaultAsync();
            if (pago == null)
            {
                return NotFound($"No existe un pago de ID= {id}");
            }

            return Ok(pago);
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostPago(Pagos pago)
        {
            try
            {
                _dbContext.Pagos.Add(pago);
                await _dbContext.SaveChangesAsync();
                //Aca nos devuelve el cliente recién creado
                return pago.pagoID;
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }

        }
//public ActionResult Put(int id, [FromBody] Huesped huesped)
        [HttpPut("{id}")]
        
        public async Task<ActionResult<Pagos>> PutPago(int id, Pagos pago)
        {
            //if (id != pago.clienteID)
            //{
            //    return BadRequest();
            //}
            //_dbContext.Pagos.Entry(pago).State = EntityState.Modified;
            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{

            //    throw;
            //}
            //return Ok($"Se ha modificado el pago de ID {pago.pagoID}");
            var pagoSolicitado = _dbContext.Pagos
   .Where(e => e.pagoID == id).FirstOrDefault();

            if (pagoSolicitado == null)
            {
                return NotFound("No se encontró el pago a modificar");
            }

            pagoSolicitado.usuarioID = pago.usuarioID;
            pagoSolicitado.polizaID = pago.polizaID;
            pagoSolicitado.clienteID = pago.clienteID;
            pagoSolicitado.fecha = pago.fecha;
            pagoSolicitado.metodoID = pago.metodoID;
            pagoSolicitado.monto = pago.monto;
            pagoSolicitado.polizaID = pago.polizaID;

            try
            {
                _dbContext.Pagos.Update(pagoSolicitado);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Los datos no se han podido actualizar");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeletePago(int id)
        {
            var pago = _dbContext.Pagos.Where(x => x.pagoID == id).FirstOrDefault();
            if (pago == null)
            {
                return NotFound($"No se encontró el pago de Id {id}");
            }
            try
            {
                _dbContext.Pagos.Remove(pago);
                await _dbContext.SaveChangesAsync();
                return Ok($"El registro de  ID: {pago.pagoID} se ha eliminado correctamente");
            }
            catch (Exception e)
            {

                return BadRequest($"Los datos no pudieron ser eliminados por: {e.Message}");
            }
        }
    }
}
