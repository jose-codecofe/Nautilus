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
    public class GestorConfiguracionProducto : GestorBase<ConfiguracionProductoDto>
    {
        nautilusEntities _contexto;

        public GestorConfiguracionProducto()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(ConfiguracionProductoDto pObjeto)
        {
            configuracion_productos vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.configuracion_productos.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(ConfiguracionProductoDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            configuracion_productos vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.bitacora_fecha = pObjeto.BitacoraFecha;
            vEntidad.bitacora_usuario = pObjeto.BitacoraUsuario;
            vEntidad.Id = pObjeto.Id;
            vEntidad.precio_venta = pObjeto.PrecioVenta;
            vEntidad.producto_Id = pObjeto.ProductoId;

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            configuracion_productos vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.configuracion_productos.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<ConfiguracionProductoDto> Obtener()
        {
            List<configuracion_productos> vListaEntidad = (from vEnt in _contexto.configuracion_productos select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override ConfiguracionProductoDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private configuracion_productos ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.configuracion_productos where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
