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
    public class GestorProducto : GestorBase<ProductoDto>
    {
        nautilusEntities _contexto;

        public GestorProducto()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(ProductoDto pObjeto)
        {
            producto vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.productos.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(ProductoDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            producto vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.bitacora_fecha = pObjeto.BitacoraFecha;
            vEntidad.bitacora_usuario = pObjeto.BitacoraUsuario;
            vEntidad.Id = pObjeto.Id;
            vEntidad.codigo = pObjeto.Codigo;
            vEntidad.detalle = pObjeto.Detalle;
            vEntidad.nombre = pObjeto.Nombre;
            vEntidad.observacion = pObjeto.Observacion;
            vEntidad.precio_unitario = pObjeto.PrecioUnitario;
            vEntidad.tipo_unidad = pObjeto.TipoUnidad;

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            producto vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.productos.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<ProductoDto> Obtener()
        {
            List<producto> vListaEntidad = (from vEnt in _contexto.productos select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override ProductoDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private producto ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.productos where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
