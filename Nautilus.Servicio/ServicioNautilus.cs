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
using Nautilus.Dominio.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Servicio
{
    public class ServicioNautilus : IServicioNautilus
    {
        #region Producto
        public InformacionDto InsertarProducto(ProductoDto pObjeto)
        {
            return new GestorProducto().Insertar(pObjeto);
        }
        public InformacionDto ActualizarProducto(ProductoDto pObjeto)
        {
            return new GestorProducto().Actualizar(pObjeto);
        }
        public InformacionDto EliminarProducto(int pId)
        {
            return new GestorProducto().Eliminar(pId);
        }
        public List<ProductoDto> ObtenerProducto()
        {
            return new GestorProducto().Obtener();
        }
        public ProductoDto ObtenerProductoPorId(int pId)
        {
            return new GestorProducto().ObtenerPorId(pId);
        }
        #endregion

        #region Configuración Producto
        public InformacionDto InsertarConfiguracionProducto(ConfiguracionProductoDto pObjeto)
        {
            return new GestorConfiguracionProducto().Insertar(pObjeto);
        }

        public InformacionDto ActualizarConfiguracionProducto(ConfiguracionProductoDto pObjeto)
        {
            return new GestorConfiguracionProducto().Actualizar(pObjeto);
        }

        public InformacionDto EliminarConfiguracionProducto(int pId)
        {
            return new GestorConfiguracionProducto().Eliminar(pId);
        }

        public List<ConfiguracionProductoDto> ObtenerConfiguracionProducto()
        {
            return new GestorConfiguracionProducto().Obtener();
        }

        public ConfiguracionProductoDto ObtenerConfiguracionProductoPorId(int pId)
        {
            return new GestorConfiguracionProducto().ObtenerPorId(pId);
        }
        #endregion

        #region Empresa
        public InformacionDto InsertarEmpresa(EmpresaDto pObjeto)
        {
            return new GestorEmpresa().Insertar(pObjeto);
        }

        public InformacionDto ActualizarEmpresa(EmpresaDto pObjeto)
        {
            return new GestorEmpresa().Actualizar(pObjeto);
        }

        public InformacionDto EliminarEmpresa(int pId)
        {
            return new GestorEmpresa().Eliminar(pId);
        }

        public List<EmpresaDto> ObtenerEmpresa()
        {
            return new GestorEmpresa().Obtener();
        }

        public EmpresaDto ObtenerEmpresaPorId(int pId)
        {
            return new GestorEmpresa().ObtenerPorId(pId);
        }
        #endregion

        #region Movimiento
        public InformacionDto InsertarMovimiento(MovimientoDto pObjeto)
        {
            return new GestorMovimiento().Insertar(pObjeto);
        }

        public InformacionDto ActualizarMovimiento(MovimientoDto pObjeto)
        {
            return new GestorMovimiento().Actualizar(pObjeto);
        }

        public InformacionDto EliminarMovimiento(int pId)
        {
            return new GestorMovimiento().Eliminar(pId);
        }

        public List<MovimientoDto> ObtenerMovimiento()
        {
            return new GestorMovimiento().Obtener();
        }

        public MovimientoDto ObtenerMovimientoPorId(int pId)
        {
            return new GestorMovimiento().ObtenerPorId(pId);
        }
        #endregion

        #region Saldo Producto
        public InformacionDto InsertarSaldoProducto(SaldoProductoDto pObjeto)
        {
            return new GestorSaldoProducto().Insertar(pObjeto);
        }

        public InformacionDto ActualizarSaldoProducto(SaldoProductoDto pObjeto)
        {
            return new GestorSaldoProducto().Actualizar(pObjeto);
        }

        public InformacionDto EliminarSaldoProducto(int pId)
        {
            return new GestorSaldoProducto().Eliminar(pId);
        }

        public List<SaldoProductoDto> ObtenerSaldoProducto()
        {
            return new GestorSaldoProducto().Obtener();
        }

        public SaldoProductoDto ObtenerSaldoProductoPorId(int pId)
        {
            return new GestorSaldoProducto().ObtenerPorId(pId);
        }
        #endregion

        #region Usuario
        public InformacionDto InsertarUsuario(UsuarioDto pObjeto)
        {
            return new GestorUsuario().Insertar(pObjeto);
        }

        public InformacionDto ActualizarUsuario(UsuarioDto pObjeto)
        {
            return new GestorUsuario().Actualizar(pObjeto);
        }

        public InformacionDto EliminarUsuario(int pId)
        {
            return new GestorUsuario().Eliminar(pId);
        }

        public List<UsuarioDto> ObtenerUsuario()
        {
            return new GestorUsuario().Obtener();
        }

        public UsuarioDto ObtenerUsuarioPorId(int pId)
        {
            return new GestorUsuario().ObtenerPorId(pId);
        }
        #endregion


    }
}
