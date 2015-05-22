//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using Nautilus.Data.ORM;
using Nautilus.Dominio.Complemento;
using Nautilus.Dominio.Dto;
using Nautilus.Dominio.Dto.Anexo;
using Nautilus.Dominio.Gestor.Anexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Gestor
{
    public class GestorSaldoProducto : GestorBase<SaldoProductoDto>
    {
        nautilusEntities _contexto;

        public GestorSaldoProducto()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(SaldoProductoDto pObjeto)
        {
            saldo_productos vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.saldo_productos.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(SaldoProductoDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            saldo_productos vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.cantidad = pObjeto.Cantidad;
            vEntidad.Id = pObjeto.Id;
            vEntidad.producto_Id = pObjeto.ProductoId;

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            saldo_productos vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.saldo_productos.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<SaldoProductoDto> Obtener()
        {
            List<saldo_productos> vListaEntidad = (from vEnt in _contexto.saldo_productos select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override SaldoProductoDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private saldo_productos ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.saldo_productos where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
