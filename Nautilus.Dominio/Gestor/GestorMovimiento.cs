
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
    public class GestorMovimiento : GestorBase<MovimientoDto>
    {
        nautilusEntities _contexto;

        public GestorMovimiento()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(MovimientoDto pObjeto)
        {
            movimiento vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.movimientos.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(MovimientoDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            movimiento vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.bitacora_fecha = pObjeto.BitacoraFecha;
            vEntidad.bitacora_usuario = pObjeto.BitacoraUsuario;
            vEntidad.cantidad = pObjeto.Cantidad;
            vEntidad.Id = pObjeto.Id;
            vEntidad.producto_Id = pObjeto.ProductoId;
            vEntidad.tipo_movimiento = pObjeto.TipoMovimiento.ToString();

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            movimiento vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.movimientos.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<MovimientoDto> Obtener()
        {
            List<movimiento> vListaEntidad = (from vEnt in _contexto.movimientos select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override MovimientoDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private movimiento ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.movimientos where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
