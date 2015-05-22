//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using Nautilus.Dominio.Dto;
using Nautilus.Dominio.Dto.Anexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Gestor.Anexo
{
    public abstract class GestorBase<T>
    {
        public abstract InformacionDto Insertar(T pObjeto);
        public abstract InformacionDto Actualizar(T pObjeto);
        public abstract InformacionDto Eliminar(int pId);
        public abstract List<T> Obtener();
        public abstract T ObtenerPorId(int pId);
    }
}
