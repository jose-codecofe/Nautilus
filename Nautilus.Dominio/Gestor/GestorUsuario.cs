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
    public class GestorUsuario : GestorBase<UsuarioDto>
    {
        nautilusEntities _contexto;

        public GestorUsuario()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(UsuarioDto pObjeto)
        {
            usuario vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.usuarios.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(UsuarioDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            usuario vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.contrasenia = pObjeto.Contrasenia;
            vEntidad.email = pObjeto.Email;
            vEntidad.Id = pObjeto.Id;
            vEntidad.empresa_Id = pObjeto.EmpresaId;
            vEntidad.es_activo = pObjeto.EsActivo;
            vEntidad.nombre = pObjeto.Nombre;
            vEntidad.fecha_desde = pObjeto.FechaDesde;
            vEntidad.fecha_hasta = pObjeto.FechaHasta;
            vEntidad.empresa_Id = pObjeto.EmpresaId;

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            usuario vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.usuarios.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<UsuarioDto> Obtener()
        {
            List<usuario> vListaEntidad = (from vEnt in _contexto.usuarios select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override UsuarioDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private usuario ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.usuarios where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
