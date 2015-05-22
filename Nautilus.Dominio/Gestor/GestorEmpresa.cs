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
    public class GestorEmpresa : GestorBase<EmpresaDto>
    {
        nautilusEntities _contexto;

        public GestorEmpresa()
        {
            _contexto = new nautilusEntities();
        }

        public override InformacionDto Insertar(EmpresaDto pObjeto)
        {
            empresa vEntidad = Mapeador.MapearDtoAEntidad(pObjeto);

            if (vEntidad.Id == 0)
                _contexto.empresas.Add(vEntidad);

            InformacionDto vResultado = Contexto.GuardarModelo(_contexto);
            vResultado.Objeto = vEntidad.Id;

            return vResultado;
        }

        public override InformacionDto Actualizar(EmpresaDto pObjeto)
        {
            if (pObjeto == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            empresa vEntidad = ObtenerEntidadPorId(pObjeto.Id);
            vEntidad.celular = pObjeto.Celular;
            vEntidad.email = pObjeto.Email;
            vEntidad.email_ceo = pObjeto.EmailCeo;
            vEntidad.Id = pObjeto.Id;
            vEntidad.nit = pObjeto.Nit;
            vEntidad.nombre = pObjeto.Nombre;
            vEntidad.nombre_ceo = pObjeto.NombreCeo;
            vEntidad.num_doc_ceo = pObjeto.NumDocCeo;
            vEntidad.site = pObjeto.Site;
            vEntidad.skype = pObjeto.Skype;
            vEntidad.telefono = pObjeto.Telefono;

            return Contexto.GuardarModelo(_contexto);
        }

        public override InformacionDto Eliminar(int pId)
        {
            empresa vEntidad = ObtenerEntidadPorId(pId);

            if (vEntidad == null)
                return new InformacionDto { EsCorrecto = false, Mensaje = Constante.OBJETO_NULO };

            _contexto.empresas.Remove(vEntidad);
            return Contexto.GuardarModelo(_contexto);
        }

        public override List<EmpresaDto> Obtener()
        {
            List<empresa> vListaEntidad = (from vEnt in _contexto.empresas select vEnt).ToList();
            return Mapeador.MapearListaEntidadAListaDto(vListaEntidad);
        }

        public override EmpresaDto ObtenerPorId(int pId)
        {
            return Mapeador.MapearEntidadADto(ObtenerEntidadPorId(pId));
        }

        private empresa ObtenerEntidadPorId(int pId)
        {
            return (from vEnt in _contexto.empresas where vEnt.Id.Equals(pId) select vEnt).FirstOrDefault();
        }
    }
}
